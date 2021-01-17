using SportsbookAggregation.Alerts.Models;
using SportsbookAggregation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace SportsbookAggregation.Alerts
{
    class AlertsService
    {
        public static void Run(Context dbContext)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential basicAuthenticationInfo = new
               System.Net.NetworkCredential("SportsAggregation@gmail.com", "MattNick69");
            client.Credentials = basicAuthenticationInfo;
            var now = DateTime.UtcNow;

            var futureGames = dbContext.GameRepository.Read().Where(g => g.TimeStamp > now).ToList();
            foreach (var game in futureGames)
            {
                var gameLine = GetBestAvailableGameLine(game.GameId, null, dbContext);
                var homeTeam = dbContext.TeamRepository.Read().Single(g => g.TeamId == game.HomeTeamId).Mascot;
                var awayTeam = dbContext.TeamRepository.Read().Single(g => g.TeamId == game.AwayTeamId).Mascot;


                if (gameLine.CurrentHomeSpread != 0 && gameLine.CurrentHomeSpread != null && isSpreadOpportunity(gameLine))
                {
                    if (!AlertAlreadySent(dbContext, game.GameId, "Spread"))
                    {
                        SendAlerts(client, $"Spread Opportunity - {homeTeam} vs {awayTeam} - Home Spread: {gameLine.CurrentHomeSpread} {gameLine.CurrentHomeSpreadPayout} at {gameLine.HomeSpreadSite}. Away Spread: {gameLine.CurrentAwaySpread} {gameLine.CurrentAwaySpreadPayout} at {gameLine.AwaySpreadSite}");
                        DocumentAlert(dbContext, gameLine, game.GameId, "Spread");
                    }
                }
                if (isMoneyLineOpportunity(gameLine))
                {
                    if (!AlertAlreadySent(dbContext, game.GameId, "MoneyLine"))
                    { 
                        var bookWithWrongLine = GetBookWithWrongLineMoneyLine(dbContext, game.GameId, gameLine);
                        var betPercentOnHomeTeam = GetBetPercentForHomeTeam(gameLine.CurrentHomeMoneyLine.Value, gameLine.CurrentAwayMoneyLine.Value);
                        var ROI = GetBetROI(betPercentOnHomeTeam, 1, gameLine.CurrentHomeMoneyLine.Value);
                        var sportName = dbContext.SportRepository.Read().Single(s => s.SportId == game.SportId).Name;
                        SendAlerts(client, $"ML: {Environment.NewLine}" +
                            $"{homeTeam} vs {awayTeam} {game.Sport.Name} {Environment.NewLine}" +
                            $"{homeTeam} Odds: {gameLine.CurrentHomeMoneyLine} at {gameLine.HomeMoneyLineSite} {Environment.NewLine}" +
                            $"{awayTeam} Odds: {gameLine.CurrentAwayMoneyLine} at {gameLine.AwayMoneyLineSite} {Environment.NewLine}" +
                            $"First bet at {bookWithWrongLine} {Environment.NewLine}" +
                            $"Amount: {Math.Round(betPercentOnHomeTeam,2)}x on {homeTeam}. x on {awayTeam} {Environment.NewLine}" +
                            $"ROI: {Math.Round(ROI,2)}%");
                        DocumentAlert(dbContext, gameLine, game.GameId, "MoneyLine");
                    }
                }
                if (gameLine.CurrentOver != null && gameLine.CurrentOver != 0 && isOverUnderOpportunity(gameLine))
                {
                    if (!AlertAlreadySent(dbContext, game.GameId, "Over/Under"))
                    {
                        SendAlerts(client, $"Over/Under Opportunity - {homeTeam} vs {awayTeam} - Over: {gameLine.CurrentOver} {gameLine.CurrentOverPayout} at {gameLine.OverSite}. Under: {gameLine.CurrentUnder} {gameLine.CurrentUnderPayout} at {gameLine.UnderSite}");
                        DocumentAlert(dbContext, gameLine, game.GameId, "Over/Under");
                    }
                }
            }
            client.ServicePoint.CloseConnectionGroup(client.ServicePoint.ConnectionName);
            dbContext.SaveChanges();
        }

        private static double GetBetROI(double betPercentOnHomeTeam, double betPercentOnAwayTeam, int homeOdds)
        {
            return 100 * ((betPercentOnHomeTeam * (GetDecimalOdds(homeOdds) - 1) - betPercentOnAwayTeam) / (betPercentOnHomeTeam + betPercentOnAwayTeam)); 
        }

        private static double GetBetPercentForHomeTeam(double homeLine, double awayLine)
        {
            var decimalHome = GetDecimalOdds(homeLine);
            var decimalAway = GetDecimalOdds(awayLine);

            return decimalAway / decimalHome;
        }

        private static double GetDecimalOdds(double line)
        {
            return line >= 100 ? (line / 100) + 1 : (100 / Math.Abs(line)) + 1;
        }

        private static string GetBookWithWrongLineMoneyLine(Context context, Guid gameId, BestAvailableGameLine gameline)
        {
            var allBooks = context.GamblingSiteRepository.Read();
            var bestLineWithoutHomeBook = GetBestAvailableGameLine(gameId, string.Join(",",allBooks.Where(b => b.Name != gameline.HomeMoneyLineSite).Select(b => b.Name)), context);
            var bestLineWithoutAwayBook = GetBestAvailableGameLine(gameId, string.Join(",", allBooks.Where(b => b.Name != gameline.AwayMoneyLineSite).Select(b => b.Name)), context);
            if (bestLineWithoutAwayBook.CurrentHomeMoneyLine == null || bestLineWithoutHomeBook == null)
                return "Inconclusive";
            
            return Math.Abs(gameline.CurrentHomeMoneyLine.Value) - Math.Abs(bestLineWithoutHomeBook.CurrentHomeMoneyLine.Value) > Math.Abs(gameline.CurrentAwayMoneyLine.Value) - Math.Abs(bestLineWithoutAwayBook.CurrentAwayMoneyLine.Value) ?
                gameline.HomeMoneyLineSite:
                gameline.AwayMoneyLineSite;
        }

        public static bool AlertAlreadySent(Context context, Guid gameId, string type)
        {
            var sentAlerts = context.AlertRepository.Read().Where(a => a.GameId == gameId && a.Type == type);
            return sentAlerts.Count() != 0;
        }
        public static void DocumentAlert(Context context, BestAvailableGameLine gameLine,Guid gameId, string type)
        {
            var alert = mapGameLineToAlert(gameLine, gameId, type);
            context.AlertRepository.CreateWithoutSaving(alert);
        }

        public static Alert mapGameLineToAlert(BestAvailableGameLine gameLine, Guid gameId, string type)
        {
            return new Alert
            {
                CurrentAwayMoneyLine = gameLine.CurrentAwayMoneyLine,
                CurrentAwaySpread = gameLine.CurrentAwaySpread,
                CurrentAwaySpreadPayout = gameLine.CurrentAwaySpreadPayout,
                CurrentHomeMoneyLine = gameLine.CurrentHomeMoneyLine,
                CurrentHomeSpread = gameLine.CurrentHomeSpread,
                CurrentHomeSpreadPayout = gameLine.CurrentHomeSpreadPayout,
                CurrentOver = gameLine.CurrentOver,
                CurrentOverPayout = gameLine.CurrentOverPayout,
                CurrentUnder = gameLine.CurrentUnder,
                CurrentUnderPayout = gameLine.CurrentUnderPayout,
                GameId = gameId,
                Type = type
            };
        }
        public static bool isSpreadOpportunity(BestAvailableGameLine gameLine)
        {
            if (gameLine.CurrentAwaySpread == gameLine.CurrentHomeSpread)
            {
                if (gameLine.CurrentAwaySpreadPayout + gameLine.CurrentHomeSpreadPayout > 0)
                    return true;
            }
            if(Math.Abs(gameLine.CurrentAwaySpread.Value) - Math.Abs(gameLine.CurrentHomeSpread.Value) > 5)
            {
                if (gameLine.CurrentHomeSpreadPayout > -121 && gameLine.CurrentAwaySpreadPayout > -121)
                    return true;
            }
            return false;
        }

        public static bool isMoneyLineOpportunity(BestAvailableGameLine gameLine)
        {
            return gameLine.CurrentAwayMoneyLine + gameLine.CurrentHomeMoneyLine > 0;
        }

        public static bool isOverUnderOpportunity(BestAvailableGameLine gameLine)
        {
            if (gameLine.CurrentOver == gameLine.CurrentUnder)
            {
                if (gameLine.CurrentAwaySpreadPayout + gameLine.CurrentHomeSpreadPayout > 0)
                    return true;
            }
            if (Math.Abs(gameLine.CurrentOver.Value) - Math.Abs(gameLine.CurrentUnder.Value) > 5)
            {
                if (gameLine.CurrentHomeSpreadPayout > -121 && gameLine.CurrentAwaySpreadPayout > -121)
                    return true;
            }
            return false;
        }

        public static void SendAlerts(SmtpClient client, string content)
        {
            if(Convert.ToBoolean(Program.Configuration["SendTexts"]))
            {
                List<string> contentList = new List<string>();
                int maxLength = 130;
                int i = 0;
                for(; i < content.Length - maxLength; i+=maxLength)
                {
                    contentList.Add(content.Substring(i, maxLength));
                }

                contentList.Add(content.Substring(i));

                foreach (string messageBody in contentList)
                {
                    var message = new MailMessage();
                    message.From = new MailAddress("SportsAggregation@gmail.com");

                    message.To.Add(new MailAddress("4102927305@vtext.com")); //Nick
                    message.To.Add(new MailAddress("3015025056@vtext.com")); //Myers
                    message.To.Add(new MailAddress("4842134124@messaging.sprintpcs.com")); //Murph
                    message.To.Add(new MailAddress("8456531433@vtext.com")); //Chris
                    message.Body = messageBody;

                    try
                    {
                        client.Send(message);
                    }
                    catch
                    {
                        //We sent to many alerts :(
                    }
                }
            }
        }

        public static BestAvailableGameLine GetBestAvailableGameLine(Guid id, string sportsbooks, Context context)
        {
            var bestAvailableGameLine = new BestAvailableGameLine();
            string[] sportsbooksArray = null;
            if (sportsbooks == null)
                sportsbooksArray = context.GamblingSiteRepository.Read().Select(g => g.Name).ToArray();
            else
                sportsbooksArray = sportsbooks?.Split(',');
            var availableGameLines = context.GameLineRepository.Read().Where(r => r.GameId == id && r.IsAvailable);

            var gamblingSites = context.GamblingSiteRepository.Read().ToList();
            foreach (var availableGameLine in availableGameLines)
            {
                var gamblingSiteName = gamblingSites.First(s => s.GamblingSiteId == availableGameLine.GamblingSiteId).Name;
                if (sportsbooksArray != null && !sportsbooksArray.Contains(gamblingSiteName))
                    continue;
                if (bestAvailableGameLine.CurrentHomeSpread == availableGameLine.CurrentSpread &&
                    bestAvailableGameLine.CurrentHomeSpreadPayout < availableGameLine.HomeSpreadPayout)
                {
                    bestAvailableGameLine.CurrentHomeSpreadPayout = availableGameLine.HomeSpreadPayout;
                    bestAvailableGameLine.HomeSpreadSite = gamblingSiteName;
                }
                else if (bestAvailableGameLine.CurrentHomeSpread == null ||
                    bestAvailableGameLine.CurrentHomeSpread < availableGameLine.CurrentSpread)
                {
                    bestAvailableGameLine.CurrentHomeSpreadPayout = availableGameLine.HomeSpreadPayout;
                    bestAvailableGameLine.CurrentHomeSpread = availableGameLine.CurrentSpread;
                    bestAvailableGameLine.HomeSpreadSite = gamblingSiteName;
                }

                var currentAwaySpread = availableGameLine.CurrentSpread * -1;
                if (bestAvailableGameLine.CurrentAwaySpread == currentAwaySpread &&
                    bestAvailableGameLine.CurrentAwaySpreadPayout < availableGameLine.AwaySpreadPayout)
                {
                    bestAvailableGameLine.CurrentAwaySpreadPayout = availableGameLine.AwaySpreadPayout;
                    bestAvailableGameLine.AwaySpreadSite = gamblingSiteName;
                }
                else if (bestAvailableGameLine.CurrentAwaySpread == null ||
                    bestAvailableGameLine.CurrentAwaySpread < currentAwaySpread)
                {
                    bestAvailableGameLine.CurrentAwaySpreadPayout = availableGameLine.AwaySpreadPayout;
                    bestAvailableGameLine.CurrentAwaySpread = currentAwaySpread;
                    bestAvailableGameLine.AwaySpreadSite = gamblingSiteName;
                }

                if (bestAvailableGameLine.CurrentOver == availableGameLine.CurrentOverUnder &&
                    bestAvailableGameLine.CurrentOverPayout < availableGameLine.OverPayOut)
                {
                    bestAvailableGameLine.CurrentOverPayout = availableGameLine.OverPayOut;
                    bestAvailableGameLine.OverSite = gamblingSiteName;
                }
                else if (bestAvailableGameLine.CurrentOver == null ||
                    bestAvailableGameLine.CurrentOver > availableGameLine.CurrentOverUnder)
                {
                    bestAvailableGameLine.CurrentOver = availableGameLine.CurrentOverUnder;
                    bestAvailableGameLine.CurrentOverPayout = availableGameLine.OverPayOut;
                    bestAvailableGameLine.OverSite = gamblingSiteName;
                }

                if (bestAvailableGameLine.CurrentUnder == availableGameLine.CurrentOverUnder &&
                    bestAvailableGameLine.CurrentUnderPayout < availableGameLine.UnderPayout)
                {
                    bestAvailableGameLine.CurrentUnderPayout = availableGameLine.UnderPayout;
                    bestAvailableGameLine.UnderSite = gamblingSiteName;
                }
                else if (bestAvailableGameLine.CurrentUnder == null ||
                    bestAvailableGameLine.CurrentUnder < availableGameLine.CurrentOverUnder)
                {
                    bestAvailableGameLine.CurrentUnder = availableGameLine.CurrentOverUnder;
                    bestAvailableGameLine.CurrentUnderPayout = availableGameLine.UnderPayout;
                    bestAvailableGameLine.UnderSite = gamblingSiteName;
                }

                if (bestAvailableGameLine.CurrentHomeMoneyLine == null || bestAvailableGameLine.CurrentHomeMoneyLine <
                    availableGameLine.HomeMoneyLinePayout)
                {
                    bestAvailableGameLine.CurrentHomeMoneyLine = availableGameLine.HomeMoneyLinePayout;
                    bestAvailableGameLine.HomeMoneyLineSite = gamblingSiteName;
                }

                if (bestAvailableGameLine.CurrentAwayMoneyLine == null || bestAvailableGameLine.CurrentAwayMoneyLine <
                    availableGameLine.AwayMoneyLinePayout)
                {
                    bestAvailableGameLine.CurrentAwayMoneyLine = availableGameLine.AwayMoneyLinePayout;
                    bestAvailableGameLine.AwayMoneyLineSite = gamblingSiteName;
                }
            }

            return bestAvailableGameLine;
        }
    }
}

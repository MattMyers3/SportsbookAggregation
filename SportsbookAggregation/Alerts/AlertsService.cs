using SportsbookAggregation.Alerts.Models;
using SportsbookAggregation.Data;
using System;
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
                var gameLine = GetBestAvailableGameLine(game.GameId, dbContext);
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
                        SendAlerts(client, $"Money Line Opportunity - {homeTeam} vs {awayTeam} - Home MoneyLine: {gameLine.CurrentHomeMoneyLine} at {gameLine.HomeMoneyLineSite}. Away Money Line: {gameLine.CurrentAwayMoneyLine} at {gameLine.AwayMoneyLineSite}");
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
        }

        public static bool AlertAlreadySent(Context context, Guid gameId, string type)
        {
            var sentAlerts = context.AlertRepository.Read().Where(a => a.GameId == gameId && a.Type == type);
            return sentAlerts.Count() != 0;
        }
        public static void DocumentAlert(Context context, BestAvailableGameLine gameLine,Guid gameId, string type)
        {
            var alert = mapGameLineToAlert(gameLine, gameId, type);
            context.AlertRepository.Create(alert);
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
            var message = new MailMessage();
            message.From = new MailAddress("SportsAggregation@gmail.com");

            message.To.Add(new MailAddress("4102927305@vtext.com")); //Nick
            message.To.Add(new MailAddress("3015025056@vtext.com")); //Myers
            message.To.Add(new MailAddress("4842134124@messaging.sprintpcs.com")); //Murph
            message.To.Add(new MailAddress("7179798657@txt.att.net")); //Jordan

            message.Subject = "Free Money";
            message.Body = content;

           
            client.Send(message);
        }

        public static BestAvailableGameLine GetBestAvailableGameLine(Guid id, Context context)
        {
            var bestAvailableGameLine = new BestAvailableGameLine();

            var availableGameLines = context.GameLineRepository.Read().Where(r => r.GameId == id).ToList();
            if (!availableGameLines.Any())
                return null;

            var gamblingSites = context.GamblingSiteRepository.Read().ToList();
            foreach (var availableGameLine in availableGameLines)
            {
                var gamblingSiteName = gamblingSites.First(s => s.GamblingSiteId == availableGameLine.GamblingSiteId).Name;
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

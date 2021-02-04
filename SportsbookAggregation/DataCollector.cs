using SportsbookAggregation.Alerts;
using SportsbookAggregation.Alerts.Models;
using SportsbookAggregation.Data;
using SportsbookAggregation.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SportsbookAggregation
{
    public static class DataCollector
    {
        public static void Run(Context context)
        {
            DateTime nflStart = new DateTime(2020, 9, 9);
            DateTime nflEnd = new DateTime(2021, 1, 4);
            var books = new List<string>() { "FanDuel", "FoxBet", "DraftKings", "BetRivers", "Parx", "BetAmerica", "Caesars", "Sugarhouse", "Barstool" };
            var allBooksAverage =CalcVigOfGames(context.GameLineRepository.Read().Where(g => g.Game.Sport.Name == "NFL" && g.Game.TimeStamp > nflStart && g.Game.TimeStamp < nflEnd));
            LogLines("All Book Avg: " + allBooksAverage);
            foreach(var book in books)
            {
                var bookVig = CalcVigOfGames(context.GameLineRepository.Read().Where(g => g.GamblingSite.Name == book && g.Game.Sport.Name == "NFL" && g.Game.TimeStamp > nflStart && g.Game.TimeStamp < nflEnd));
                LogLines(book + ": " + bookVig);
            }

            var gameIds = context.GameRepository.Read().Where(g => g.Sport.Name == "NFL" && g.TimeStamp > nflStart && g.TimeStamp < nflEnd).Select(x => x.GameId).ToList();
            var bestVig = CalcVigOfBestGameLines(gameIds, context);
            LogLines("Best Vig: " + bestVig);
        }

        public static double CalcVigOfGames(IEnumerable<GameLine> gameLines)
        {
            double vigSum = 0;
            int count = 0;
            foreach (var gameLine in gameLines)
            {
                if (gameLine.AwayMoneyLinePayout == null || gameLine.HomeMoneyLinePayout == null)
                    continue;

                vigSum += CalcVig(Convert.ToDouble(gameLine.AwayMoneyLinePayout), Convert.ToDouble(gameLine.HomeMoneyLinePayout));
                count++;
            }
            return vigSum / count;
        }

        public static double CalcVigOfBestGameLines(IEnumerable<Guid> gameIds, Context context)
        {
            double vigSum = 0;
            int count = 0;
            foreach (var gameId in gameIds)
            {
                var bestLine = GetBestGameLinesFromGameId(gameId, context);
                if (bestLine.CurrentAwayMoneyLine == null || bestLine.CurrentHomeMoneyLine == null)
                    continue;

                vigSum += CalcVig(Convert.ToDouble(bestLine.CurrentAwayMoneyLine), Convert.ToDouble(bestLine.CurrentHomeMoneyLine));
                count++;
            }
            return vigSum / count;
        }
        public static double CalcVig(double line1, double line2)
        {  
            return ChanceOfWinning(line1) + ChanceOfWinning(line2) - 100;
        }

        public static double ChanceOfWinning(double line)
        {
            return line > 0 ? ((100.0 / (line + 100.0)) * 100.0) : ((Math.Abs(line) / (Math.Abs(line) + 100.0)) * 100.0);
        }

        public static void LogLines(string message)
        {
            string filePath = "Lines.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(message);
            }
        }

        public static BestAvailableGameLine GetBestGameLinesFromGameId(Guid id, Context context)
        {
            var bestAvailableGameLine = new BestAvailableGameLine();
            var sportsbooksArray = context.GamblingSiteRepository.Read().Select(g => g.Name).ToArray();
            var availableGameLines = context.GameLineRepository.Read().Where(r => r.GameId == id);

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

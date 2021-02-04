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
                var bestLine = AlertsService.GetBestAvailableGameLine(gameId, null, context);
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
    }
}

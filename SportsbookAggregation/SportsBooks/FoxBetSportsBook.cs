using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;

namespace SportsbookAggregation.SportsBooks
{
    public class FoxBetSportsBook : ISportsBook
    {
        private const string InitialRequest =
            "https://sports.mtairycasino.foxbet.com/sportsbook/v1/api/getSportTree?sport=BASKETBALL&includeOutrights=false&includeEvents=false&channelId=15";

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var initialJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(InitialRequest).Result);

            return GetBasketballOfferings(initialJson);
        }

        private static IEnumerable<GameOffering> GetBasketballOfferings(dynamic initialJson)
        {
            var usaCategoryJson = ((IEnumerable) initialJson.categories).Cast<dynamic>()
                .First(g => g.name == "USA");

            return GetNbaGameOfferings(usaCategoryJson);
        }

        private static IEnumerable<GameOffering> GetNbaGameOfferings(dynamic usaCategoryJson)
        {
            var nbaCompetitionJson =
                ((IEnumerable) usaCategoryJson.competition).Cast<dynamic>().FirstOrDefault(g => g.name == "NBA");
            var nbaGamesUrl =
                $"https://sports.mtairycasino.foxbet.com/sportsbook/v1/api/getCompetitionEvents?competitionId={nbaCompetitionJson.id}&includeOutrights=false&channelId=15&locale=en-us&siteId=134217728";
            var nbaGamesJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(nbaGamesUrl).Result).ToString()
                    .Replace("event", "events");

            var games = JsonConvert.DeserializeObject<dynamic>(nbaGamesJson).events;
            var gameOfferings = new List<GameOffering>();
            foreach (var game in games)
            {
                gameOfferings.Add(ParseNbaGameOffering(game));
            }

            return gameOfferings;
        }

        private static GameOffering ParseNbaGameOffering(dynamic gameJson)
        {
            var gameOffering = new GameOffering
            {
                Site = "FoxBet",
                DateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddMilliseconds(Convert.ToDouble(gameJson.eventsTime.Value)).AddHours(-5),
            };
            var participantList = ((IEnumerable) gameJson.participants.participant).Cast<dynamic>().ToList();
            gameOffering.HomeTeam = participantList.Single(p => p.type == "HOME").names.longName;
            gameOffering.AwayTeam = participantList.Single(p => p.type == "AWAY").names.longName;

            var moneyLineInfo = ((IEnumerable) gameJson.markets).Cast<dynamic>()
                .FirstOrDefault(m => m.name.Value.Contains("Money Line"));
            if (moneyLineInfo != null)
            {
                var moneyLineInfoSelections = ((IEnumerable) moneyLineInfo.selection).Cast<dynamic>().ToList();
                gameOffering.HomeMoneyLinePayout = CalculateOdds(moneyLineInfoSelections
                    .First(s => s.names.longName == gameOffering.HomeTeam).odds.frac.Value);
                gameOffering.AwayMoneyLinePayout = CalculateOdds(moneyLineInfoSelections
                    .First(s => s.names.longName == gameOffering.AwayTeam).odds.frac.Value);
            }

            var spreadJson = ((IEnumerable) gameJson.markets).Cast<dynamic>()
                .FirstOrDefault(m => m.name.Value.Contains("Spread"));
            if (spreadJson != null)
            {
                var spreadInfo = spreadJson.selection;
                var spreadInfoSelections = ((IEnumerable) spreadInfo).Cast<dynamic>().ToList();
                gameOffering.CurrentSpread = Convert.ToInt32(spreadJson.line);
                gameOffering.HomeSpreadPayout = CalculateOdds(spreadInfoSelections
                    .First(s => s.names.longName.Value.Contains(gameOffering.HomeTeam)).odds.frac.Value);
                gameOffering.AwaySpreadPayout = CalculateOdds(spreadInfoSelections
                    .First(s => s.names.longName.Value.Contains(gameOffering.AwayTeam)).odds.frac.Value);
            }

            var totalPointsInfo = ((IEnumerable) gameJson.markets).Cast<dynamic>()
                .FirstOrDefault(m => m.name.Value.Contains("Total Points"));
            if (totalPointsInfo != null && totalPointsInfo.selection[0].odds.frac != '-')
            {
                var totalPointsInfoSelection = ((IEnumerable) totalPointsInfo.selection).Cast<dynamic>().ToList();
                gameOffering.CurrentOverUnder = Convert.ToDouble(totalPointsInfo.line);
                gameOffering.OverPayOut = CalculateOdds(totalPointsInfoSelection
                    .First(s => s.names.longName.Value.Contains("Over")).odds.frac.Value);
                gameOffering.UnderPayout = CalculateOdds(totalPointsInfoSelection
                    .First(s => s.names.longName.Value.Contains("Under")).odds.frac.Value);
            }

            return gameOffering;
        }

        private static int CalculateOdds(string fraction)
        {
            var splitFraction = fraction.Split(new char[] {'/'});
            double.TryParse(splitFraction[0], out var numerator);
            double.TryParse(splitFraction[1], out var denominator);
            if (denominator == 0)
                throw new DivideByZeroException();

            var fracAsDouble = numerator / denominator;
            if (fracAsDouble >= 1)
                return Convert.ToInt32(fracAsDouble * 100);

            return -1 * Convert.ToInt32(100 / fracAsDouble);
        }
    }
}
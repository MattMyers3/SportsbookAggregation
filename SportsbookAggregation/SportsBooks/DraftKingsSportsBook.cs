using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SportsbookAggregation.SportsBooks
{
    public class DraftKingsSportsBook : ISportsBook
    {
        private const string NbaRequestUrl =
            "https://sportsbook.draftkings.com//sites/US-SB/api/v1/eventgroup/103/full?includePromotions=true&format=json";
        private const string NflRequestUrl =
            "https://sportsbook.draftkings.com//sites/US-SB/api/v1/eventgroup/3/full?includePromotions=true&format=json";

        public string GetSportsBookName()
        {
            return "DraftKings";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var basketballOfferings = GetBasketballOfferings();
            var footballOfferings = GetFootballOfferings();

            return basketballOfferings.Concat(footballOfferings);
        }

        private IEnumerable<GameOffering> GetBasketballOfferings()
        {
            return GetGameOfferings(NbaRequestUrl);
        }

        private IEnumerable<GameOffering> GetFootballOfferings()
        {
            return GetGameOfferings(NflRequestUrl);
        }

        private static IEnumerable<GameOffering> GetGameOfferings(string sportRequestUrl)
        {
            var requestJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(sportRequestUrl).Result);

            var gameEvents = ((IEnumerable)requestJson.eventGroup.events).Cast<dynamic>();
            var gameLinesJson = ((IEnumerable)requestJson.eventGroup.offerCategories).Cast<dynamic>().First(g => g.name == "Game Lines");
            var gamesJson = ((IEnumerable)gameLinesJson.offerSubcategoryDescriptors).Cast<dynamic>().First(g => g.name == "Game");
            var gameOfferingsJson = ((IEnumerable)gamesJson.offerSubcategory.offers).Cast<dynamic>();
            var gameOfferings = new List<GameOffering>();
            foreach (var gameOfferingJson in gameOfferingsJson)
            {
                var eventId = ((IEnumerable)gameOfferingJson).Cast<dynamic>().First().providerEventId.Value;
                var gameEventJson = ((IEnumerable)gameEvents).Cast<dynamic>().First(g => g.providerEventId == eventId);

                gameOfferings.Add(ParseGameOffering(gameOfferingJson, gameEventJson));
            }

            return gameOfferings;
        }

        private static GameOffering ParseGameOffering(dynamic gameJson, dynamic detailJson)
        {
            var teams = detailJson.name.Value.Split('@');
            var gameOffering = new GameOffering
            {
                Site = "DraftKings",
                Sport = detailJson.eventGroupName,
                AwayTeam = teams[0].Trim(),
                HomeTeam = teams[1].Trim(),
                DateTime = detailJson.startDate.Value.AddHours(-4)
            };

            var pointSpreadJson = ((IEnumerable)gameJson).Cast<dynamic>().FirstOrDefault(g => g.label == "Point Spread");
            var totalPointsJson = ((IEnumerable)gameJson).Cast<dynamic>().FirstOrDefault(g => g.label == "Total Points");
            var moneylineJson = ((IEnumerable)gameJson).Cast<dynamic>().FirstOrDefault(g => g.label == "Moneyline");

            if (pointSpreadJson != null)
            {
                gameOffering.CurrentSpread = pointSpreadJson.outcomes[1].line.Value;
                gameOffering.HomeSpreadPayout = Convert.ToInt32(pointSpreadJson.outcomes[1].oddsAmerican.Value);
                gameOffering.AwaySpreadPayout = Convert.ToInt32(pointSpreadJson.outcomes[0].oddsAmerican.Value);
            }

            if (moneylineJson != null)
            {
                gameOffering.HomeMoneyLinePayout = Convert.ToInt32(moneylineJson.outcomes[1].oddsAmerican.Value);
                gameOffering.AwayMoneyLinePayout = Convert.ToInt32(moneylineJson.outcomes[0].oddsAmerican.Value);
            }

            if (totalPointsJson != null)
            {
                gameOffering.CurrentOverUnder = totalPointsJson.outcomes[0].line.Value;
                gameOffering.OverPayOut = Convert.ToInt32(totalPointsJson.outcomes[0].oddsAmerican.Value);
                gameOffering.UnderPayout = Convert.ToInt32(totalPointsJson.outcomes[1].oddsAmerican.Value);
            }

            return gameOffering;
        }
    }
}

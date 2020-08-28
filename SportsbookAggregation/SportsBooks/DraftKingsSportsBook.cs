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

        public string GetSportsBookName()
        {
            return "DraftKings";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            return GetBasketballOfferings();
        }

        private IEnumerable<GameOffering> GetBasketballOfferings()
        {
            return GetNbaGameOfferings();
        }

        private IEnumerable<GameOffering> GetNbaGameOfferings()
        {
            var nbaRequestJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(NbaRequestUrl).Result);

            var nbaGameEvents = ((IEnumerable)nbaRequestJson.eventGroup.events).Cast<dynamic>();
            var nbaGameLinesJson = ((IEnumerable)nbaRequestJson.eventGroup.offerCategories).Cast<dynamic>().First(g => g.name == "Game Lines");
            var nbaGamesJson = ((IEnumerable)nbaGameLinesJson.offerSubcategoryDescriptors).Cast<dynamic>().First(g => g.name == "Game");
            var nbaGameOfferingsJson = ((IEnumerable)nbaGamesJson.offerSubcategory.offers).Cast<dynamic>();
            var gameOfferings = new List<GameOffering>();
            foreach (var nbaGameOfferingJson in nbaGameOfferingsJson)
            {
                var eventId = ((IEnumerable)nbaGameOfferingJson).Cast<dynamic>().First().providerEventId.Value;
                var nbaGameEventJson = ((IEnumerable)nbaGameEvents).Cast<dynamic>().First(g => g.providerEventId == eventId);

                gameOfferings.Add(ParseNbaGameOffering(nbaGameOfferingJson, nbaGameEventJson));
            }

            return gameOfferings;
        }

        private GameOffering ParseNbaGameOffering(dynamic gameJson, dynamic detailJson)
        {
            var teams = detailJson.name.Value.Split('@');
            var gameOffering = new GameOffering
            {
                Site = GetSportsBookName(),
                Sport = detailJson.eventGroupName,
                AwayTeam = teams[0].Trim(),
                HomeTeam = teams[1].Trim(),
                DateTime = detailJson.startDate.Value.AddHours(-4)
            };

            var pointSpreadJson = ((IEnumerable)gameJson).Cast<dynamic>().FirstOrDefault(g => g.label == "Point Spread");
            var totalPointsJson = ((IEnumerable)gameJson).Cast<dynamic>().FirstOrDefault(g => g.label == "Total Points");
            var moneylineJson = ((IEnumerable)gameJson).Cast<dynamic>().FirstOrDefault(g => g.label == "Moneyline");

            if(pointSpreadJson != null)
            {
                gameOffering.CurrentSpread = pointSpreadJson.outcomes[1].line.Value;
                gameOffering.HomeSpreadPayout = Convert.ToInt32(pointSpreadJson.outcomes[1].oddsAmerican.Value);
                gameOffering.AwaySpreadPayout = Convert.ToInt32(pointSpreadJson.outcomes[0].oddsAmerican.Value);
            }

            if(moneylineJson != null)
            {
                gameOffering.HomeMoneyLinePayout = Convert.ToInt32(moneylineJson.outcomes[1].oddsAmerican.Value);
                gameOffering.AwayMoneyLinePayout = Convert.ToInt32(moneylineJson.outcomes[0].oddsAmerican.Value);
            }

            if(totalPointsJson != null)
            {
                gameOffering.CurrentOverUnder = totalPointsJson.outcomes[0].line.Value;
                gameOffering.OverPayOut = Convert.ToInt32(totalPointsJson.outcomes[0].oddsAmerican.Value);
                gameOffering.UnderPayout = Convert.ToInt32(totalPointsJson.outcomes[1].oddsAmerican.Value);
            }

            return gameOffering;
        }
    }
}

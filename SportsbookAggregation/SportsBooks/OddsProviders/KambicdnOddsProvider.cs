using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SportsbookAggregation.SportsBooks.OddsProviders
{
    class KambicdnOddsProvider
    {
        private readonly string site;
        private readonly string NbaRequestUrl;
        private readonly string NflRequestUrl;
        
        public KambicdnOddsProvider(string sportsbook, string siteRouteName, string ncid)
        {
            site = sportsbook;
            NbaRequestUrl = $"https://eu-offering.kambicdn.org/offering/v2018/{siteRouteName}/listView/basketball/nba.json?lang=en_US&market=US&client_id=2&channel_id=1&ncid={ncid}&useCombined=true";
            NflRequestUrl = $"https://eu-offering.kambicdn.org/offering/v2018/{siteRouteName}/listView/american_football/nfl.json?lang=en_US&market=US&client_id=2&channel_id=1&ncid={ncid}&useCombined=true";
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

        private IEnumerable<GameOffering> GetGameOfferings(string sportRequestUrl)
        {
            var requestString =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(sportRequestUrl).Result).ToString().Replace("event", "Event"); //needed because event is a C# key word

            var games = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(requestString).Events).Cast<dynamic>();
            var gameOfferings = new List<GameOffering>();
            foreach (var game in games)
            {
                var eventInfo = game.Event;
                var betOffers = game.betOffers;

                gameOfferings.Add(ParseGameOffering(eventInfo, betOffers));
            }

            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic eventInfo, dynamic betOffers)
        {
            var gameOffering = new GameOffering
            {
                Site = site,
                Sport = eventInfo.group,
                AwayTeam = LocationMapper.GetFullTeamName(eventInfo.awayName.Value),
                HomeTeam = LocationMapper.GetFullTeamName(eventInfo.homeName.Value),
                DateTime = eventInfo.start.Value.AddHours(-4)
            };

            var pointSpreadJson = ((IEnumerable)betOffers).Cast<dynamic>().FirstOrDefault(g => g.criterion.label == "Point Spread");
            var totalPointsJson = ((IEnumerable)betOffers).Cast<dynamic>().FirstOrDefault(g => g.criterion.label == "Total Points");
            var moneylineJson = ((IEnumerable)betOffers).Cast<dynamic>().FirstOrDefault(g => g.criterion.label == "Moneyline");

            if (pointSpreadJson != null)
            {
                gameOffering.CurrentSpread = pointSpreadJson.outcomes[0].line.Value / 1000;
                gameOffering.HomeSpreadPayout = Convert.ToInt32(pointSpreadJson.outcomes[0].oddsAmerican.Value);
                gameOffering.AwaySpreadPayout = Convert.ToInt32(pointSpreadJson.outcomes[1].oddsAmerican.Value);
            }

            if (moneylineJson != null)
            {
                gameOffering.HomeMoneyLinePayout = Convert.ToInt32(moneylineJson.outcomes[0].oddsAmerican.Value);
                gameOffering.AwayMoneyLinePayout = Convert.ToInt32(moneylineJson.outcomes[1].oddsAmerican.Value);
            }

            if (totalPointsJson != null)
            {
                gameOffering.CurrentOverUnder = totalPointsJson.outcomes[0].line.Value / 1000;
                gameOffering.OverPayOut = Convert.ToInt32(totalPointsJson.outcomes[1].oddsAmerican.Value);
                gameOffering.UnderPayout = Convert.ToInt32(totalPointsJson.outcomes[0].oddsAmerican.Value);
            }

            return gameOffering;
        }
    }
}

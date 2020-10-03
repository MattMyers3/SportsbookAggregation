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
        private readonly string MlbRequestUrl;


        public KambicdnOddsProvider(string sportsbook, string siteRouteName)
        {
            site = sportsbook;
            NbaRequestUrl = $"https://eu-offering.kambicdn.org/offering/v2018/{siteRouteName}/listView/basketball/nba.json?lang=en_US&market=US&useCombined=true";
            NflRequestUrl = $"https://eu-offering.kambicdn.org/offering/v2018/{siteRouteName}/listView/american_football/nfl.json?lang=en_US&market=US&useCombined=true";
            MlbRequestUrl = $"https://eu-offering.kambicdn.org/offering/v2018/{siteRouteName}/listView/baseball/mlb.json?lang=en_US&market=US&useCombined=true";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var basketballOfferings = GetBasketballOfferings();
            var footballOfferings = GetFootballOfferings();
            var baseballOfferings = GetBaseballOfferings();

            return baseballOfferings.Concat(basketballOfferings.Concat(footballOfferings));
        }

        private IEnumerable<GameOffering> GetBasketballOfferings()
        {
            return GetGameOfferings(NbaRequestUrl,"Point Spread", "Moneyline", "Total Points");
        }

        private IEnumerable<GameOffering> GetFootballOfferings()
        {
            return GetGameOfferings(NflRequestUrl, "Point Spread", "Moneyline", "Total Points");
        }

        private IEnumerable<GameOffering> GetBaseballOfferings()
        {
            return GetGameOfferings(MlbRequestUrl, "Run Line", "Moneyline", "Total Runs");
        }


        private IEnumerable<GameOffering> GetGameOfferings(string sportRequestUrl, string spreadLabel, string moneyLineLabel, string totalLabel)
        {
            var requestString =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(sportRequestUrl).Result).ToString().Replace("event", "Event"); //needed because event is a C# key word

            var games = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(requestString).Events).Cast<dynamic>();
            var gameOfferings = new List<GameOffering>();
            foreach (var game in games)
            {
                var eventInfo = game.Event;
                var betOffers = game.betOffers;

                if(eventInfo.awayName != null && eventInfo.homeName != null)
                    gameOfferings.Add(ParseGameOffering(eventInfo, betOffers, spreadLabel, moneyLineLabel, totalLabel));
            }

            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic eventInfo, dynamic betOffers, string spreadLabel, string moneyLineLabel, string totalLabel)
        {
            var gameOffering = new GameOffering
            {
                Site = site,
                Sport = eventInfo.group,
                AwayTeam = LocationMapper.GetFullTeamName(eventInfo.awayName.Value, eventInfo.group.Value),
                HomeTeam = LocationMapper.GetFullTeamName(eventInfo.homeName.Value, eventInfo.group.Value),
                DateTime = eventInfo.start.Value
            };

            var pointSpreadJson = ((IEnumerable)betOffers).Cast<dynamic>().FirstOrDefault(g => g.criterion.label == spreadLabel);
            var totalPointsJson = ((IEnumerable)betOffers).Cast<dynamic>().FirstOrDefault(g => g.criterion.label == totalLabel);
            var moneylineJson = ((IEnumerable)betOffers).Cast<dynamic>().FirstOrDefault(g => g.criterion.label == moneyLineLabel);

            if (pointSpreadJson != null)
            {
                var homeSelection = ((IEnumerable)pointSpreadJson.outcomes).Cast<dynamic>().FirstOrDefault(g => LocationMapper.GetFullTeamName(g.participant.Value, gameOffering.Sport) == gameOffering.HomeTeam);
                var awaySelection = ((IEnumerable)pointSpreadJson.outcomes).Cast<dynamic>().FirstOrDefault(g => LocationMapper.GetFullTeamName(g.participant.Value, gameOffering.Sport) == gameOffering.AwayTeam);
                gameOffering.CurrentSpread = pointSpreadJson.outcomes[0].line.Value / 1000.0;
                gameOffering.HomeSpreadPayout = Convert.ToInt32(homeSelection.oddsAmerican.Value);
                gameOffering.AwaySpreadPayout = Convert.ToInt32(awaySelection.oddsAmerican.Value);
            }

            if (moneylineJson != null)
            {
                var homeSelection = ((IEnumerable)moneylineJson.outcomes).Cast<dynamic>().FirstOrDefault(g => LocationMapper.GetFullTeamName(g.participant.Value, gameOffering.Sport) == gameOffering.HomeTeam);
                var awaySelection = ((IEnumerable)moneylineJson.outcomes).Cast<dynamic>().FirstOrDefault(g => LocationMapper.GetFullTeamName(g.participant.Value, gameOffering.Sport) == gameOffering.AwayTeam);
                gameOffering.HomeMoneyLinePayout = Convert.ToInt32(homeSelection.oddsAmerican.Value);
                gameOffering.AwayMoneyLinePayout = Convert.ToInt32(awaySelection.oddsAmerican.Value);
            }

            if (totalPointsJson != null)
            {
                var overSelection = ((IEnumerable)totalPointsJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.label == "Over");
                var underSelection = ((IEnumerable)totalPointsJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.label == "Under");
                gameOffering.CurrentOverUnder = totalPointsJson.outcomes[0].line.Value / 1000.0;
                gameOffering.OverPayOut = Convert.ToInt32(overSelection.oddsAmerican.Value);
                gameOffering.UnderPayout = Convert.ToInt32(underSelection.oddsAmerican.Value);
            }

            return gameOffering;
        }
    }
}

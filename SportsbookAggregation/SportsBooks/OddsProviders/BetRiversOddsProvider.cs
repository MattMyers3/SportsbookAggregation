using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SportsbookAggregation.SportsBooks.OddsProviders
{
    class BetRiversOddsProvider
    {
        private readonly string urlHost;
        private readonly string sportsbookName;

        public BetRiversOddsProvider(string urlHost, string sportsbookName)
        {
            this.urlHost = urlHost;
            this.sportsbookName = sportsbookName;
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var initialResponse = Program.HttpClient.GetStringAsync($"{urlHost}/?l=RiversPittsburgh&page=sportsbook&feed=featured").Result;
            var hashVersion = Regex.Match(initialResponse, "\"hashVersion\": \"(.*)\"").Groups[1].Value;

            var offeringsUrl = $"{urlHost}/conf/cache.js?cv={hashVersion}";
            const string trimString = "window.args = ";
            var offeringsJsonText = TrimStart(Program.HttpClient.GetStringAsync(offeringsUrl).Result, trimString).TrimEnd(';');
            var offeringsJson = JsonConvert.DeserializeObject<dynamic>(offeringsJsonText);

            IEnumerable<GameOffering> basketballOfferings = GetBasketballOfferings(offeringsJson);
            IEnumerable<GameOffering> footballOfferings = GetFootballOfferings(offeringsJson);

            return basketballOfferings.Concat(footballOfferings);
        }

        private IEnumerable<GameOffering> GetBasketballOfferings(dynamic offeringsJson)
        {
            var nbaApiKey = ((IEnumerable)offeringsJson.eventViews.views).Cast<dynamic>()
               .First(g => g.slug == "basketball_nba").sections[0].apiKey.Value;

            var nbaOfferingsUrl = $"{urlHost}/api/service/sportsbook/offering/feed?key={nbaApiKey}";
            var nbaOfferingsJson = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(nbaOfferingsUrl).Result).events;

            return GetGameOfferings(nbaOfferingsJson);
        }

        private IEnumerable<GameOffering> GetFootballOfferings(dynamic offeringsJson)
        {
            var nflApiKey = ((IEnumerable)offeringsJson.eventViews.views).Cast<dynamic>()
               .First(g => g.slug == "football_nfl").sections[0].apiKey.Value;

            var nflOfferingsUrl = $"{urlHost}/api/service/sportsbook/offering/feed?key={nflApiKey}";
            var nflOfferingsJson = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(nflOfferingsUrl).Result).events;

            return GetGameOfferings(nflOfferingsJson);
        }

        private IEnumerable<GameOffering> GetGameOfferings(dynamic offeringsJson)
        {
            var gameOfferings = new List<GameOffering>();
            foreach (var sportOffering in offeringsJson)
            {
                var offering = ParseGameOffering(sportOffering);
                if (offering != null)
                    gameOfferings.Add(offering);
            }
            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic gameJson)
        {
            var gameOffering = new GameOffering
            {
                Site = sportsbookName,
                AwayTeam = LocationMapper.GetFullTeamName(gameJson.participants[1].name.Value, gameJson.eventInfo[1].name.Value),
                HomeTeam = LocationMapper.GetFullTeamName(gameJson.participants[0].name.Value, gameJson.eventInfo[1].name.Value),
                Sport = gameJson.eventInfo[1].name,
                DateTime = gameJson.start.Value.AddHours(-4)
            };

            var pointSpreadJson = ((IEnumerable)gameJson.betOffers).Cast<dynamic>().FirstOrDefault(g => g.betDescription == "Point Spread");
            var totalPointsJson = ((IEnumerable)gameJson.betOffers).Cast<dynamic>().FirstOrDefault(g => g.betDescription == "Total Points");
            var moneylineJson = ((IEnumerable)gameJson.betOffers).Cast<dynamic>().FirstOrDefault(g => g.betDescription == "Moneyline");

            if (pointSpreadJson == null && totalPointsJson == null && moneylineJson == null)
                return null;

            if (pointSpreadJson != null)
            {
                gameOffering.CurrentSpread = pointSpreadJson.outcomes[0].line.Value;
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
                gameOffering.CurrentOverUnder = totalPointsJson.outcomes[0].line.Value;
                gameOffering.OverPayOut = Convert.ToInt32(totalPointsJson.outcomes[0].oddsAmerican.Value);
                gameOffering.UnderPayout = Convert.ToInt32(totalPointsJson.outcomes[1].oddsAmerican.Value);
            }

            return gameOffering;
        }

        private static string TrimStart(string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString)) return target;

            string result = target;
            while (result.StartsWith(trimString))
            {
                result = result.Substring(trimString.Length);
            }

            return result;
        }
    }
}

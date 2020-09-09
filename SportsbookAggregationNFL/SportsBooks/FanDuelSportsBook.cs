using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;

namespace SportsbookAggregation.SportsBooks
{
    public class FanDuelSportsBook : ISportsBook
    {
        private const string InitialRequest = "https://sportsbook.fanduel.com/cache/psbonav/1/UK/top.json";

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var initialJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(InitialRequest).Result);

            return GetFootballOfferings(initialJson);
        }
        private static IEnumerable<GameOffering> GetFootballOfferings(dynamic initialJson)
        {
            var footballJson = ((IEnumerable)initialJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == "Football");
            return GetNflGameOfferings(footballJson);
        }
        private static IEnumerable<GameOffering> GetNflGameOfferings(dynamic footballJson)
        {
            var nflJson = ((IEnumerable)footballJson.bonavigationnodes).Cast<dynamic>().First(g => g.name == "NFL");
            var nflTabCouponJson = ((IEnumerable)nflJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == "Season Coupon");
            var gamesMarketGroup = ((IEnumerable)nflTabCouponJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name.Value.EndsWith("Games")).marketgroups[0].idfwmarketgroup;
            var nflGamesUrl = $"https://sportsbook.fanduel.com/cache/psmg/UK/{gamesMarketGroup}.json";

            var nflGamesJson = JsonConvert
                .DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(nflGamesUrl).Result).events;
            var nflGameNumbers = new List<string>();
            foreach (var nflGame in nflGamesJson)
            {
                nflGameNumbers.Add(nflGame.idfoevent.ToString());
            }

            var gameOfferings = new List<GameOffering>();
            foreach (var gameNumber in nflGameNumbers)
            {
                var nflGameUrl = $"https://sportsbook.fanduel.com/cache/psevent/UK/1/false/{gameNumber}.json";
                var gameJson =
                    JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(nflGameUrl).Result);
                gameOfferings.Add(ParseNflGameOffering(gameJson));
            }

            return gameOfferings;
        }
        private static GameOffering ParseNflGameOffering(dynamic gameJson)
        {
            var gameOffering = new GameOffering
            {
                Site = "FanDuel",
                AwayTeam = gameJson.participantname_away,
                HomeTeam = gameJson.participantname_home,
                Sport = gameJson.sportname,
                DateTime = gameJson.tsstart
            };

            if (gameJson.eventmarketgroups == null)
                return gameOffering;

            var marketList = ((IEnumerable)gameJson.eventmarketgroups).Cast<dynamic>()
                .FirstOrDefault(g => g.name == "All")?.markets;
            if (marketList == null)
                return gameOffering;

            var spreadInfo = ((IEnumerable)marketList).Cast<dynamic>().FirstOrDefault(g => g.name == "Spread")
                ?.selections;
            if (spreadInfo != null)
            {
                gameOffering.CurrentSpread = spreadInfo[0].currenthandicap;
                gameOffering.HomeSpreadPayout = CalculateOdds(spreadInfo[1].currentpricedown.Value,
                    spreadInfo[1].currentpriceup.Value);
                gameOffering.AwaySpreadPayout = CalculateOdds(spreadInfo[0].currentpricedown.Value,
                    spreadInfo[0].currentpriceup.Value);
            }

            var moneyLineInfo = ((IEnumerable)marketList).Cast<dynamic>().FirstOrDefault(g => g.name == "Moneyline")
                ?.selections;
            if (moneyLineInfo != null)
            {
                gameOffering.HomeMoneyLinePayout = CalculateOdds(moneyLineInfo[1].currentpricedown.Value,
                    moneyLineInfo[1].currentpriceup.Value);
                gameOffering.AwayMoneyLinePayout = CalculateOdds(moneyLineInfo[0].currentpricedown.Value,
                    moneyLineInfo[0].currentpriceup.Value);
            }

            var totalPointsInfo = ((IEnumerable)marketList).Cast<dynamic>()
                .FirstOrDefault(g => g.name == "Total Match Points");
            if (totalPointsInfo == null) return gameOffering;

            var totalPointsInfoSelections = totalPointsInfo?.selections;
            gameOffering.OverPayOut = CalculateOdds(totalPointsInfoSelections[0].currentpricedown.Value,
                totalPointsInfoSelections[0].currentpriceup.Value);
            gameOffering.UnderPayout = CalculateOdds(totalPointsInfoSelections[1].currentpricedown.Value,
                totalPointsInfoSelections[1].currentpriceup.Value);
            gameOffering.CurrentOverUnder = totalPointsInfo.currentmatchhandicap;

            return gameOffering;
        }

        private static int CalculateOdds(double priceDown, double priceUp)
        {
            return priceDown < priceUp
                ? Convert.ToInt32(100 / priceDown * priceUp)
                : Convert.ToInt32(-1 * (100 / priceUp) * priceDown);
        }
    }
}
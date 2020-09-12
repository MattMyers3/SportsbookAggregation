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


        public string GetSportsBookName()
        {
            return "FanDuel";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var initialJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(InitialRequest).Result);

            return GetBasketballOfferings(initialJson);
        }

        private IEnumerable<GameOffering> GetBasketballOfferings(dynamic initialJson)
        {
            var basketballJson = ((IEnumerable) initialJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == "Basketball");
            return GetNbaGameOfferings(basketballJson);
        }

        private IEnumerable<GameOffering> GetNbaGameOfferings(dynamic basketballJson)
        {
            var nbaJson = ((IEnumerable) basketballJson.bonavigationnodes).Cast<dynamic>().First(g => g.name == "NBA");
            var nbaTabCouponJson = ((IEnumerable) nbaJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == "NBA Tab Coupon");
            var gamesMarketGroup = ((IEnumerable) nbaTabCouponJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name.Value.EndsWith("Games")).marketgroups[0].idfwmarketgroup;
            var nbaGamesUrl = $"https://sportsbook.fanduel.com/cache/psmg/UK/{gamesMarketGroup}.json";

            var nbaGamesJson = JsonConvert
                .DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(nbaGamesUrl).Result).events;
            var nbaGameNumbers = new List<string>();
            foreach (var nbaGame in nbaGamesJson)
            {
                nbaGameNumbers.Add(nbaGame.idfoevent.ToString());
            }

            var gameOfferings = new List<GameOffering>();
            foreach (var gameNumber in nbaGameNumbers)
            {
                var nbaGameUrl = $"https://sportsbook.fanduel.com/cache/psevent/UK/1/false/{gameNumber}.json";
                var gameJson =
                    JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(nbaGameUrl).Result);
                gameOfferings.Add(ParseNbaGameOffering(gameJson));
            }

            return gameOfferings;
        }

        private GameOffering ParseNbaGameOffering(dynamic gameJson)
        {
            var gameOffering = new GameOffering
            {
                Site = GetSportsBookName(),
                AwayTeam = gameJson.participantname_away,
                HomeTeam = gameJson.participantname_home,
                Sport = gameJson.sportname,
                DateTime = gameJson.tsstart
            };

            if (gameJson.eventmarketgroups == null)
                return gameOffering;

            var marketList = ((IEnumerable) gameJson.eventmarketgroups).Cast<dynamic>()
                .FirstOrDefault(g => g.name == "All")?.markets;
            if (marketList == null)
                return gameOffering;

            var spreadInfo = ((IEnumerable) marketList).Cast<dynamic>().FirstOrDefault(g => g.name == "Spread Betting")
                ?.selections;
            if (spreadInfo != null)
            {
                gameOffering.CurrentSpread = spreadInfo[0].currenthandicap;
                gameOffering.HomeSpreadPayout = CalculateOdds(spreadInfo[1].currentpricedown.Value,
                    spreadInfo[1].currentpriceup.Value);
                gameOffering.AwaySpreadPayout = CalculateOdds(spreadInfo[0].currentpricedown.Value,
                    spreadInfo[0].currentpriceup.Value);
            }

            var moneyLineInfo = ((IEnumerable) marketList).Cast<dynamic>().FirstOrDefault(g => g.name == "Moneyline")
                ?.selections;
            if (moneyLineInfo != null)
            {
                gameOffering.HomeMoneyLinePayout = CalculateOdds(moneyLineInfo[1].currentpricedown.Value,
                    moneyLineInfo[1].currentpriceup.Value);
                gameOffering.AwayMoneyLinePayout = CalculateOdds(moneyLineInfo[0].currentpricedown.Value,
                    moneyLineInfo[0].currentpriceup.Value);
            }

            var totalPointsInfo = ((IEnumerable) marketList).Cast<dynamic>()
                .FirstOrDefault(g => g.name == "Total Points Scored");
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
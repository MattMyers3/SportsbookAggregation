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
            var initialJson = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(InitialRequest).Result);

            IEnumerable<GameOffering> basketballOfferings = GetBasketballOfferings(initialJson);
            IEnumerable<GameOffering> footballOfferings = GetFootballOfferings(initialJson);
            IEnumerable<GameOffering> baseballOfferings = GetBaseballOfferings(initialJson);


            return baseballOfferings.Concat(basketballOfferings.Concat(footballOfferings));
        }

        private IEnumerable<GameOffering> GetBasketballOfferings(dynamic initialJson)
        {
            var basketballJson = ((IEnumerable) initialJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == "Basketball");
            return GetGameOfferings(basketballJson, "NBA", "NBA Tab Coupon", "Spread Betting", "Moneyline", "Total Points Scored");
        }

        private IEnumerable<GameOffering> GetFootballOfferings(dynamic initialJson)
        {
            var footballJson = ((IEnumerable)initialJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == "Football");
            return GetGameOfferings(footballJson,  "NFL", "Season Coupon", "Spread", "Moneyline", "Total Match Points");
        }

        private IEnumerable<GameOffering> GetBaseballOfferings(dynamic initialJson)
        {
            var footballJson = ((IEnumerable)initialJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == "Baseball");
            return GetGameOfferings(footballJson, "MLB", "MLB Tab Coupon", "Run Line", "Money Line", "Total Runs");
        }

        private IEnumerable<GameOffering> GetGameOfferings(dynamic json, string sport, string tabCouponName, string spreadLabel, string moneyLineLabel, string totalLabel)
        {
            var sportJson = ((IEnumerable)json.bonavigationnodes).Cast<dynamic>().First(g => g.name == sport);
            var tabCouponJson = ((IEnumerable)sportJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == tabCouponName);
            var gamesMarketGroup = ((IEnumerable)tabCouponJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name.Value == "Games").marketgroups[0].idfwmarketgroup;
            var gamesUrl = $"https://sportsbook.fanduel.com/cache/psmg/UK/{gamesMarketGroup}.json";

            var sportsGamesJson = JsonConvert
                .DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(gamesUrl).Result).events;
            var gameNumbers = new List<string>();
            foreach (var game in sportsGamesJson)
            {
                gameNumbers.Add(game.idfoevent.ToString());
            }

            var gameOfferings = new List<GameOffering>();
            foreach (var gameNumber in gameNumbers)
            {
                var gameUrl = $"https://sportsbook.fanduel.com/cache/psevent/UK/1/false/{gameNumber}.json";
                var gameJson =
                    JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(gameUrl).Result);
                gameOfferings.Add(ParseGameOffering(gameJson, spreadLabel, moneyLineLabel, totalLabel));
            }

            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic gameJson, string spreadLabel, string moneyLineLabel, string totalLabel)
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

            var spreadInfo = ((IEnumerable) marketList).Cast<dynamic>().FirstOrDefault(g => g.name.Value.Contains(spreadLabel))
                ?.selections;
            if (spreadInfo != null)
            {
                gameOffering.CurrentSpread = spreadInfo[0].currenthandicap;
                gameOffering.HomeSpreadPayout = CalculateOdds(spreadInfo[1].currentpricedown.Value,
                    spreadInfo[1].currentpriceup.Value);
                gameOffering.AwaySpreadPayout = CalculateOdds(spreadInfo[0].currentpricedown.Value,
                    spreadInfo[0].currentpriceup.Value);
            }

            var moneyLineInfo = ((IEnumerable) marketList).Cast<dynamic>().FirstOrDefault(g => g.name.Value.Contains(moneyLineLabel))
                ?.selections;
            if (moneyLineInfo != null)
            {
                gameOffering.HomeMoneyLinePayout = CalculateOdds(moneyLineInfo[1].currentpricedown.Value,
                    moneyLineInfo[1].currentpriceup.Value);
                gameOffering.AwayMoneyLinePayout = CalculateOdds(moneyLineInfo[0].currentpricedown.Value,
                    moneyLineInfo[0].currentpriceup.Value);
            }

            var totalPointsInfo = ((IEnumerable) marketList).Cast<dynamic>()
                .FirstOrDefault(g => g.name.Value.Contains(totalLabel));
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
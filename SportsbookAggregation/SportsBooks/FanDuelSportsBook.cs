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
            IEnumerable<GameOffering> nflOfferings = GetNFLOfferings(initialJson);
            IEnumerable<GameOffering> baseballOfferings = GetBaseballOfferings(initialJson);
            IEnumerable<GameOffering> ncaafOfferings = GetNCAAFOfferings(initialJson);

            return ncaafOfferings.Concat(baseballOfferings.Concat(basketballOfferings.Concat(nflOfferings)));
        }

        private IEnumerable<GameOffering> GetBasketballOfferings(dynamic initialJson)
        {
            var basketballJson = ((IEnumerable) initialJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == "Basketball");
            return GetGameOfferings(basketballJson, "NBA", "NBA Tab Coupon", "Spread Betting", "Moneyline", "Total Points Scored");
        }

        private IEnumerable<GameOffering> GetNFLOfferings(dynamic initialJson)
        {
            var footballJson = ((IEnumerable)initialJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == "Football");
            return GetGameOfferings(footballJson,  "NFL", "Season Coupon", "Spread", "Moneyline", "Total Match Points");
        }

        private IEnumerable<GameOffering> GetNCAAFOfferings(dynamic initialJson)
        {
            var footballJson = ((IEnumerable)initialJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == "College Football");
            var games = GetGameOfferings(footballJson, "Games", "CFB Coupon", "Spread", "Moneyline", "Total Match Points");
            foreach (var offering in games)
            {
                offering.AwayTeam = LocationMapper.GetFullTeamName(offering.AwayTeam, offering.Sport);
                offering.HomeTeam = LocationMapper.GetFullTeamName(offering.HomeTeam, offering.Sport);
            }

            return games;
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
            var gamesMarketGroups = ((IEnumerable)tabCouponJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name.Value.ToString().Contains("Games")).marketgroups;
            if (gamesMarketGroups.Count == 0)
                return Enumerable.Empty<GameOffering>();//This could create silent failing. It's not parsing NBA Finals because the name is NBA Finals instead of Games

            var gamesMarketGroup = gamesMarketGroups[0].idfwmarketgroup;
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

            if (gameOffering.Sport == "College Football")
                gameOffering.Sport = "NCAAF"; //can we move this to a higher level mapper?

            gameOffering.DateTime = gameOffering.DateTime.AddHours(4);
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
                .FirstOrDefault(g => g.name.Value == totalLabel);
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

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            var initialJson = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(InitialRequest).Result);

            var boostJson = ((IEnumerable)initialJson.bonavigationnodes).Cast<dynamic>()
                .First(g => g.name == "Boosts");

            List<OddsBoostOffering> boosts = new List<OddsBoostOffering>();
            boosts.AddRange(GetOddsBoosts(boostJson));
            boosts.AddRange(GetSuperBoosts(boostJson));
            return boosts;
        }

        private IEnumerable<OddsBoostOffering> GetOddsBoosts(dynamic boostJson)
        {
            var oddsBoostJson = ((IEnumerable)boostJson.bonavigationnodes).Cast<dynamic>().First(g => g.name == "Odds Boosts");
            var obCouponJson = ((IEnumerable)oddsBoostJson.bonavigationnodes).Cast<dynamic>().First(g => g.name == "OB Coupon");
            var sportMarketGroups = ((IEnumerable)obCouponJson.bonavigationnodes).Cast<dynamic>().First(g => g.name.Value == "Odds Boosts").marketgroups;

            if (sportMarketGroups.Count == 0)
                return Enumerable.Empty<OddsBoostOffering>();

            var oddsBoostOfferings = new List<OddsBoostOffering>();
            foreach(var marketGroup in sportMarketGroups)
            {
                var marketGroupNumber = marketGroup.idfwmarketgroup;
                var groupUrl = $"https://sportsbook.fanduel.com/cache/psmg/UK/{marketGroupNumber}.json";
                var oddsBoostEvents = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(groupUrl).Result).events;
                foreach(var boostEvent in oddsBoostEvents)
                {
                    oddsBoostOfferings.Add(GetOddsBoostOffering(boostEvent));
                }                
            }
            return oddsBoostOfferings;
        }

        private IEnumerable<OddsBoostOffering> GetSuperBoosts(dynamic boostJson)
        {
            var oddsBoostJson = ((IEnumerable)boostJson.bonavigationnodes).Cast<dynamic>().First(g => g.name == "Super Boosts");
            var obCouponJson = ((IEnumerable)oddsBoostJson.bonavigationnodes).Cast<dynamic>().First(g => g.name == "SB Coupon");
            var sportMarketGroups = ((IEnumerable)obCouponJson.bonavigationnodes).Cast<dynamic>().First(g => g.name.Value == "Super Boosts").marketgroups;

            if (sportMarketGroups.Count == 0)
                return Enumerable.Empty<OddsBoostOffering>();

            var oddsBoostOfferings = new List<OddsBoostOffering>();
            foreach (var marketGroup in sportMarketGroups)
            {
                var marketGroupNumber = marketGroup.idfwmarketgroup;
                var groupUrl = $"https://sportsbook.fanduel.com/cache/psmg/UK/{marketGroupNumber}.json";
                var oddsBoostEvents = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(groupUrl).Result).events;
                foreach (var boostEvent in oddsBoostEvents)
                {
                    oddsBoostOfferings.Add(GetOddsBoostOffering(boostEvent));
                }
            }
            return oddsBoostOfferings;
        }

        private OddsBoostOffering GetOddsBoostOffering(dynamic boostEvent)
        {
            var oddsBoostOffering = new OddsBoostOffering
            {
                Site = GetSportsBookName(),
                Date = boostEvent.tsstart,
                Description = boostEvent.externaldescription,
                Sport = boostEvent.sportname
            };

            var oddsBoostSelections = ((IEnumerable)boostEvent.markets).Cast<dynamic>().FirstOrDefault()?.selections;
            oddsBoostOffering.PreviousOdds = CalculateOdds(oddsBoostSelections[0].estimatepricedown.Value, oddsBoostSelections[0].estimatepriceup.Value);
            oddsBoostOffering.BoostedOdds = CalculateOdds(oddsBoostSelections[0].currentpricedown.Value, oddsBoostSelections[0].currentpriceup.Value);
            return oddsBoostOffering;
        }
    }
}
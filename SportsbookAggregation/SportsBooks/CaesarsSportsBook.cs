using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SportsbookAggregation.SportsBooks
{
    public class CaesarsSportBook : ISportsBook
    {
        private const string NbaCode = "77";
        private const string NflCode = "55";
        private const string NcaafCode = "58";

        public string GetSportsBookName()
        {
            return "Caesars";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var basketballOfferings = GetBasketballOfferings();
            var footballOfferings = GetFootballOfferings();
            var ncaafOfferings = GetNCAFFOfferings();

            return ncaafOfferings.Concat(basketballOfferings.Concat(footballOfferings));
        }

        private IEnumerable<GameOffering> GetBasketballOfferings()
        {
            return GetGameOfferings(NbaCode, "NBA");
        }

        private IEnumerable<GameOffering> GetFootballOfferings()
        {
            return GetGameOfferings(NflCode, "NFL");
        }

        private IEnumerable<GameOffering> GetNCAFFOfferings()
        {
            var games = GetGameOfferings(NcaafCode, "NCAAF");
            foreach (var offering in games)
            {
                offering.AwayTeam = LocationMapper.GetFullTeamName(offering.AwayTeam, offering.Sport);
                offering.HomeTeam = LocationMapper.GetFullTeamName(offering.HomeTeam, offering.Sport);
            }

            return games;
        }

        private string GetSportsUrl(string sportsCode)
        {
            return $"https://sb-content.pa.caesarsonline.com/content-service/api/v1/q/event-list?started=false&active=true&marketSortsIncluded=HH%2CHL%2CMR%2CWH&eventSortsIncluded=MTCH&includeChildMarkets=true&drilldownTagIds={sportsCode}";
        }

        private IEnumerable<GameOffering> GetGameOfferings(string sportsCode, string sportName)
        {
            var responseString =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(GetSportsUrl(sportsCode)).Result);

            var games = ((IEnumerable)responseString.data.events).Cast<dynamic>();
            var gameOfferings = new List<GameOffering>();
            foreach (var game in games)
            {
                gameOfferings.Add(ParseGameOffering(game, sportName));
            }

            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic game, string sportName)
        {
            var gameOffering = new GameOffering
            {
                Site = GetSportsBookName(),
                Sport = sportName,
                DateTime = game.startTime.Value
            };

            gameOffering.HomeTeam = ((IEnumerable)game.teams).Cast<dynamic>().FirstOrDefault(g => g.side == "HOME").name;
            gameOffering.AwayTeam = ((IEnumerable)game.teams).Cast<dynamic>().FirstOrDefault(g => g.side == "AWAY").name;

            if (gameOffering.HomeTeam.StartsWith("Look Ahead") || gameOffering.AwayTeam.StartsWith("Look Ahead"))//Don't Ask
                return new GameOffering();

            var markets = ((IEnumerable)game.markets).Cast<dynamic>();
            if (gameOffering.HomeTeam == "Washington Football Team" || gameOffering.AwayTeam == "Washington Football Team")
                markets = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(markets.ToString().Replace("Washington Redskins", "Washington Football Team"))).Cast<dynamic>();

            var pointSpreadJson = markets.FirstOrDefault(g => g.name == "Spread");
            var totalPointsJson = markets.FirstOrDefault(g => g.name == "Total Points Over/Under");
            var moneylineJson = markets.FirstOrDefault(g => g.name == "Money Line");

            if (pointSpreadJson != null && pointSpreadJson.status != "SUSPENDED")
            {
                var homeSelection = ((IEnumerable)pointSpreadJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.subType == "H");
                var awaySelection = ((IEnumerable)pointSpreadJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.subType == "A");
                gameOffering.CurrentSpread = pointSpreadJson.handicapValue;
                gameOffering.HomeSpreadPayout = Convert.ToInt32(CalculateOdds(homeSelection.prices[0].denominator.Value, homeSelection.prices[0].numerator.Value));
                gameOffering.AwaySpreadPayout = Convert.ToInt32(CalculateOdds(awaySelection.prices[0].denominator.Value, awaySelection.prices[0].numerator.Value));
            }

            if (moneylineJson != null && moneylineJson.status != "SUSPENDED")
            {
                var homeSelection = ((IEnumerable)moneylineJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.subType == "H");
                var awaySelection = ((IEnumerable)moneylineJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.subType == "A");
                if(homeSelection.status != "SUSPENDED")
                    gameOffering.HomeMoneyLinePayout = Convert.ToInt32(CalculateOdds(homeSelection.prices[0].denominator.Value, homeSelection.prices[0].numerator.Value));
                if (awaySelection.status != "SUSPENDED")
                    gameOffering.AwayMoneyLinePayout = Convert.ToInt32(CalculateOdds(awaySelection.prices[0].denominator.Value, awaySelection.prices[0].numerator.Value));
            }

            if (totalPointsJson != null && totalPointsJson.status != "SUSPENDED")
            {
                var overSelection = ((IEnumerable)totalPointsJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.name == "Over");
                var underSelection = ((IEnumerable)totalPointsJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.name == "Under");
                gameOffering.CurrentOverUnder = totalPointsJson.handicapValue;
                gameOffering.OverPayOut = Convert.ToInt32(CalculateOdds(overSelection.prices[0].denominator.Value, overSelection.prices[0].numerator.Value));
                gameOffering.UnderPayout = Convert.ToInt32(CalculateOdds(underSelection.prices[0].denominator.Value, underSelection.prices[0].numerator.Value));
            }

            return gameOffering;
        }

        private static int CalculateOdds(double denominator, double numerator)
        {
            return denominator < numerator
                ? Convert.ToInt32(100 / denominator * numerator)
                : Convert.ToInt32(-1 * (100 / numerator) * denominator);
        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            return new List<OddsBoostOffering>();
        }
    }
}

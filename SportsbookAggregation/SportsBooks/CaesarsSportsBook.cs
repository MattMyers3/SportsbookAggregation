using Newtonsoft.Json;
using SportsbookAggregation.Data.Models;
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

        public string GetSportsBookName()
        {
            return "Caesars";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var basketballOfferings = GetBasketballOfferings();
            var footballOfferings = GetFootballOfferings();

            return basketballOfferings.Concat(footballOfferings);
        }

        private IEnumerable<GameOffering> GetBasketballOfferings()
        {
            return GetGameOfferings(NbaCode);
        }

        private IEnumerable<GameOffering> GetFootballOfferings()
        {
            return GetGameOfferings(NflCode);
        }

        private string GetSportsUrl(string sportsCode)
        {
            var date = DateTime.UtcNow.ToString("yyyy-MM-dd"); //No idea if this is right. Having trouble testing. Might need to redo some of this book, site might have updated
            return $"https://sb-content.pa.caesarsonline.com/content-service/api/v1/q/event-list?startTimeFrom={date}&started=false&active=true&maxMarkets=10&orderMarketsBy=displayOrder&marketSortsIncluded=HH%2CHL%2CMR%2CWH&eventSortsIncluded=MTCH&includeChildMarkets=true&prioritisePrimaryMarkets=true&includeMedia=true&drilldownTagIds={sportsCode}";
        }

        private IEnumerable<GameOffering> GetGameOfferings(string sportsCode)
        {
            var responseString =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(GetSportsUrl(sportsCode)).Result);

            var games = ((IEnumerable)responseString.data.events).Cast<dynamic>();
            var gameOfferings = new List<GameOffering>();
            foreach (var game in games)
            {
                gameOfferings.Add(ParseGameOffering(game));
            }

            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic game)
        {
            var gameOffering = new GameOffering
            {
                Site = GetSportsBookName(),
                Sport = GetSport(game),
                DateTime = game.startTime.Value
            };

            gameOffering.HomeTeam = ((IEnumerable)game.teams).Cast<dynamic>().FirstOrDefault(g => g.side == "HOME").name;
            gameOffering.AwayTeam = ((IEnumerable)game.teams).Cast<dynamic>().FirstOrDefault(g => g.side == "AWAY").name;

            var markets = ((IEnumerable)game.markets).Cast<dynamic>();
            if (gameOffering.HomeTeam == "Washington Football Team" || gameOffering.AwayTeam == "Washington Football Team")
                markets = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(markets.ToString().Replace("Washington Redskins", "Washington Football Team"))).Cast<dynamic>();

            var pointSpreadJson = markets.FirstOrDefault(g => g.name == "Spread");
            var totalPointsJson = markets.FirstOrDefault(g => g.name == "Total Points Over/Under");
            var moneylineJson = markets.FirstOrDefault(g => g.name == "Money Line");

            if (pointSpreadJson != null && pointSpreadJson.status != "SUSPENDED")
            {
                var homeSelection = ((IEnumerable)pointSpreadJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.name == gameOffering.HomeTeam);
                var awaySelection = ((IEnumerable)pointSpreadJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.name == gameOffering.AwayTeam);
                gameOffering.CurrentSpread = pointSpreadJson.handicapValue;
                gameOffering.HomeSpreadPayout = Convert.ToInt32(CalculateOdds(homeSelection.prices[0].denominator.Value, homeSelection.prices[0].numerator.Value));
                gameOffering.AwaySpreadPayout = Convert.ToInt32(CalculateOdds(awaySelection.prices[0].denominator.Value, awaySelection.prices[0].numerator.Value));
            }

            if (moneylineJson != null && moneylineJson.status != "SUSPENDED")
            {
                var homeSelection = ((IEnumerable)moneylineJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.name == gameOffering.HomeTeam);
                var awaySelection = ((IEnumerable)moneylineJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.name == gameOffering.AwayTeam);
                gameOffering.HomeMoneyLinePayout = Convert.ToInt32(CalculateOdds(homeSelection.prices[0].denominator.Value, homeSelection.prices[0].numerator.Value));
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

        private string GetSport(dynamic game)
        {
            switch (game.category.code.Value)
            {
                case "AMERICAN_FOOTBAL"://this is not a typo
                    return "NFL";
                case "BASKETBALL":
                    return "NBA";
                default:
                     throw new Exception(game.category.code.Value + " not a recognized sport");

            }

        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            return new List<OddsBoostOffering>();
        }
    }
}

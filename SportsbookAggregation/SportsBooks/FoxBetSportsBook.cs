using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SportsbookAggregation.Data.Models;
using SportsbookAggregation.SportsBooks.Models;

namespace SportsbookAggregation.SportsBooks
{
    public class FoxBetSportsBook : ISportsBook
    {
        private const string InitialBasketballRequest =
            "https://sports.mtairycasino.foxbet.com/sportsbook/v1/api/getSportTree?sport=BASKETBALL&includeOutrights=false&includeEvents=false&channelId=15";
        private const string InitialFootballRequest =
            "https://sports.mtairycasino.foxbet.com/sportsbook/v1/api/getSportTree?sport=AMERICAN_FOOTBALL&includeOutrights=false&includeEvents=false&channelId=15";
        private const string InitialBaseballRequest =
            "https://sports.mtairycasino.foxbet.com/sportsbook/v1/api/getSportTree?sport=BASEBALL&includeOutrights=false&includeEvents=false&channelId=15";


        public string GetSportsBookName()
        {
            return "FoxBet";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var basketballOfferings = GetBasketballOfferings().ToList();
            var nflOfferings = GetNFLOfferings().ToList();
            var baseballOfferings = GetBaseballOfferings().ToList();
            var ncaafOfferings = GetNCAAFOfferings().ToList();
            var ncaabOfferings = GetNCAABOfferings().ToList();


            return ncaabOfferings.Concat(ncaafOfferings.Concat(baseballOfferings.Concat(basketballOfferings.Concat(nflOfferings))));
        }

        private IEnumerable<GameOffering> GetBasketballOfferings()
        {
            var initialJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(InitialBasketballRequest).Result);

            var usaCategoryJson = ((IEnumerable) initialJson.categories).Cast<dynamic>()
                .FirstOrDefault(g => g.name == "USA");

            if(usaCategoryJson == null)
                return Enumerable.Empty<GameOffering>();

            return GetGameOfferings(usaCategoryJson, "NBA", "Money Line", "Spread", "Total Points");
        }

        private IEnumerable<GameOffering> GetNFLOfferings()
        {
            var initialJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(InitialFootballRequest).Result);

            var usaCategoryJson = ((IEnumerable)initialJson.categories).Cast<dynamic>()
                .FirstOrDefault(g => g.competition[0].names.longName == "NFL");

            if (usaCategoryJson == null)
                return Enumerable.Empty<GameOffering>();

            return GetGameOfferings(usaCategoryJson, "NFL", "Money Line", "Spread", "Total Points");
        }

        private IEnumerable<GameOffering> GetBaseballOfferings()
        {
            var initialJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(InitialBaseballRequest).Result);

            var usaCategoryJson = ((IEnumerable)initialJson.categories).Cast<dynamic>()
                .FirstOrDefault(g => g.name == "USA");

            if (usaCategoryJson == null)
                return Enumerable.Empty<GameOffering>();

            return GetGameOfferings(usaCategoryJson, "MLB", "Money Line", "Run Line", "Total Runs");
        }

        private IEnumerable<GameOffering> GetNCAAFOfferings()
        {
            var initialJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(InitialFootballRequest).Result);

            var usaCategoryJson = ((IEnumerable)initialJson.categories).Cast<dynamic>()
                .FirstOrDefault(g => g.competition[0].names.longName == "NCAAF");

            if (usaCategoryJson == null)
                return Enumerable.Empty<GameOffering>();

            IEnumerable<GameOffering> gameOfferings = GetGameOfferings(usaCategoryJson, "NCAAF", "Money Line", "Spread", "Total Points");

            return gameOfferings;
        }

        private IEnumerable<GameOffering> GetNCAABOfferings()
        {
            var initialJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(InitialBasketballRequest).Result);

            var usaCategoryJson = ((IEnumerable)initialJson.categories).Cast<dynamic>()
                .FirstOrDefault(g => g.name == "USA");

            if (usaCategoryJson == null)
                return Enumerable.Empty<GameOffering>();

            IEnumerable<GameOffering> gameOfferings = GetGameOfferings(usaCategoryJson, "NCAAB", "Money Line", "Spread", "Total Points");

            return gameOfferings;
        }

        private IEnumerable<GameOffering> GetGameOfferings(dynamic usaCategoryJson, string sportName, string moneyLineLabel, string spreadLabel, string totalLabel)
        {
            var nflCompetitionJson =
                ((IEnumerable)usaCategoryJson.competition).Cast<dynamic>().FirstOrDefault(g => g.name.Value.Contains(sportName));
            if (nflCompetitionJson == null)
            {
                return Enumerable.Empty<GameOffering>();
            }
            var nflGamesUrl =
                $"https://sports.mtairycasino.foxbet.com/sportsbook/v1/api/getCompetitionEvents?competitionId={nflCompetitionJson.id}&includeOutrights=false&channelId=15&locale=en-us&siteId=134217728";
            var nflGamesJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(nflGamesUrl).Result).ToString()
                    .Replace("event", "events");

            var games = JsonConvert.DeserializeObject<dynamic>(nflGamesJson).events;
            var gameOfferings = new List<GameOffering>();
            foreach (var game in games)
            {
                var gameOffering = ParseGameOffering(game, moneyLineLabel, spreadLabel, totalLabel, sportName);
                gameOffering.Sport = sportName;
                gameOfferings.Add(gameOffering);
            }

            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic gameJson, string moneyLineLabel, string spreadLabel, string totalLabel, string sportName)
        {
            var gameOffering = new GameOffering
            {
                Site = GetSportsBookName(),
                DateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddMilliseconds(Convert.ToDouble(gameJson.eventsTime.Value))
            };
            var participantList = ((IEnumerable) gameJson.participants.participant).Cast<dynamic>().ToList();
            gameOffering.HomeTeam = participantList.Single(p => p.type == "HOME").names.longName;
            gameOffering.AwayTeam = participantList.Single(p => p.type == "AWAY").names.longName;

            var moneyLineInfo = ((IEnumerable) gameJson.markets).Cast<dynamic>()
                .FirstOrDefault(m => m.name.Value.Contains(moneyLineLabel));
            if (moneyLineInfo != null && moneyLineInfo.selection[0].odds.frac != '-')
            {
                var moneyLineInfoSelections = ((IEnumerable) moneyLineInfo.selection).Cast<dynamic>().ToList();
                gameOffering.HomeMoneyLinePayout = CalculateOdds(moneyLineInfoSelections
                    .First(s => s.names.longName == gameOffering.HomeTeam).odds.frac.Value);
                gameOffering.AwayMoneyLinePayout = CalculateOdds(moneyLineInfoSelections
                    .First(s => s.names.longName == gameOffering.AwayTeam).odds.frac.Value);
            }

            var spreadJson = ((IEnumerable) gameJson.markets).Cast<dynamic>()
                .FirstOrDefault(m => m.name.Value.Contains(spreadLabel) && m.mostBalanced?.Value ?? true && m.displayed?.Value ?? true);
            if (spreadJson != null && spreadJson.selection[0].odds.frac.Value != "-")
            {
                var spreadInfo = spreadJson.selection;
                var spreadInfoSelections = ((IEnumerable) spreadInfo).Cast<dynamic>().ToList();
                gameOffering.CurrentSpread = Convert.ToDouble(spreadJson.line);
                gameOffering.HomeSpreadPayout = CalculateOdds(spreadInfoSelections
                    .First(s => s.names.longName.Value.Contains(gameOffering.HomeTeam)).odds.frac.Value);
                gameOffering.AwaySpreadPayout = CalculateOdds(spreadInfoSelections
                    .First(s => s.names.longName.Value.Contains(gameOffering.AwayTeam)).odds.frac.Value);
            }

            var totalPointsInfo = ((IEnumerable) gameJson.markets).Cast<dynamic>()
                .FirstOrDefault(m => m.name.Value.Contains(totalLabel) && m.displayed?.Value ?? true);
            if (totalPointsInfo != null && totalPointsInfo.selection[0].odds.frac != '-')
            {
                var totalPointsInfoSelection = ((IEnumerable) totalPointsInfo.selection).Cast<dynamic>().ToList();
                gameOffering.CurrentOverUnder = Convert.ToDouble(totalPointsInfo.line);
                gameOffering.OverPayOut = CalculateOdds(totalPointsInfoSelection
                    .First(s => s.names.longName.Value.Contains("Over")).odds.frac.Value);
                gameOffering.UnderPayout = CalculateOdds(totalPointsInfoSelection
                    .First(s => s.names.longName.Value.Contains("Under")).odds.frac.Value);
            }

            if (gameOffering.HomeTeam == "Washington" && sportName == "NFL")
                gameOffering.HomeTeam = "Washington Football Team";
            else if (gameOffering.AwayTeam == "Washington" && sportName == "NFL")
                gameOffering.AwayTeam = "Washington Football Team";

            return gameOffering;
        }

        private static int CalculateOdds(string fraction)
        {
            var splitFraction = fraction.Split(new char[] {'/'});
            double.TryParse(splitFraction[0], out var numerator);
            double.TryParse(splitFraction[1], out var denominator);
            if (denominator == 0)
                throw new DivideByZeroException();

            var fracAsDouble = numerator / denominator;
            if (fracAsDouble >= 1)
                return Convert.ToInt32(fracAsDouble * 100);

            return -1 * Convert.ToInt32(100 / fracAsDouble);
        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            var sports = new string[] { "football", "mlb" };
            var oddsBoosts = new List<OddsBoostOffering>();
            foreach(var sport in sports)
            {
                var boostUrl = $"https://sports.mtairycasino.foxbet.com/sportsbook/v1/api/getCouponCompetitions?slug={sport}-odds-boost-pa&channelId=15";
                var sportInformationJson = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(boostUrl).Result.ToString().Replace("event", "events"));
                var leagueListJson = ((IEnumerable) sportInformationJson).Cast<dynamic>();
                foreach(var leagueJson in leagueListJson)
                {
                    var gamesJson = ((IEnumerable)leagueJson.events).Cast<dynamic>();
                    foreach(var gameJson in gamesJson)
                    {
                        var sportName = gameJson.compName.ToString();
                        var game = gameJson.name.ToString();
                        var gameTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Convert.ToDouble(gameJson.eventsTime.Value));
                        var boostsJson = ((IEnumerable)gameJson.markets[0].selection).Cast<dynamic>();
                        foreach (var boostJson in boostsJson)
                        { 
                            oddsBoosts.Add(ParseOddsBoost(boostJson, game, sportName, gameTime));
                        }
                    }
                }
            }

            return oddsBoosts;
        }

        private OddsBoostOffering ParseOddsBoost(dynamic boostJson, string game, string sportName, DateTime gameTime)
        {
            var betDesc = boostJson.names.longName;
            var prevPriceJson = ((IEnumerable)boostJson.wasPrice).Cast<dynamic>();

            return new OddsBoostOffering()
            {
                BoostedOdds = CalculateOdds(boostJson.odds.frac.Value),
                PreviousOdds = prevPriceJson.Any(b => b.channel == "PA") ? CalculateOdds(prevPriceJson.Single(b => b.channel == "PA").fractionalOdds.Value) : 0,
                Description = $"({game}) {betDesc}",
                Sport = sportName,
                Date = gameTime,
                Site = GetSportsBookName()
            };
        }
    }
}
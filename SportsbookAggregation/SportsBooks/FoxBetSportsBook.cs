using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SportsbookAggregation.Constants;
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

            var usaCategoryJson = ((IEnumerable)initialJson.categories).Cast<dynamic>()
                .FirstOrDefault(g => g.name == "USA");

            if (usaCategoryJson == null)
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
            var participantList = ((IEnumerable)gameJson.participants.participant).Cast<dynamic>().ToList();
            gameOffering.HomeTeam = participantList.Single(p => p.type == "HOME").names.longName;
            gameOffering.AwayTeam = participantList.Single(p => p.type == "AWAY").names.longName;

            var moneyLineInfo = ((IEnumerable)gameJson.markets).Cast<dynamic>()
                .FirstOrDefault(m => m.name.Value.Contains(moneyLineLabel));
            if (moneyLineInfo != null && moneyLineInfo.selection[0].odds.frac != '-')
            {
                var moneyLineInfoSelections = ((IEnumerable)moneyLineInfo.selection).Cast<dynamic>().ToList();
                gameOffering.HomeMoneyLinePayout = CalculateOdds(moneyLineInfoSelections
                    .First(s => s.names.longName == gameOffering.HomeTeam).odds.frac.Value);
                gameOffering.AwayMoneyLinePayout = CalculateOdds(moneyLineInfoSelections
                    .First(s => s.names.longName == gameOffering.AwayTeam).odds.frac.Value);
            }

            var spreadJson = ((IEnumerable)gameJson.markets).Cast<dynamic>()
                .FirstOrDefault(m => m.name.Value.Contains(spreadLabel) && m.mostBalanced?.Value ?? true && m.displayed?.Value ?? true);
            if (spreadJson != null && spreadJson.selection[0].odds.frac.Value != "-")
            {
                var spreadInfo = spreadJson.selection;
                var spreadInfoSelections = ((IEnumerable)spreadInfo).Cast<dynamic>().ToList();
                gameOffering.CurrentSpread = Convert.ToDouble(spreadJson.line);
                gameOffering.HomeSpreadPayout = CalculateOdds(spreadInfoSelections
                    .First(s => s.names.longName.Value.Contains(gameOffering.HomeTeam)).odds.frac.Value);
                gameOffering.AwaySpreadPayout = CalculateOdds(spreadInfoSelections
                    .First(s => s.names.longName.Value.Contains(gameOffering.AwayTeam)).odds.frac.Value);
            }

            var totalPointsInfo = ((IEnumerable)gameJson.markets).Cast<dynamic>()
                .FirstOrDefault(m => m.name.Value.Contains(totalLabel) && m.displayed?.Value ?? true);
            if (totalPointsInfo != null && totalPointsInfo.selection[0].odds.frac != '-')
            {
                var totalPointsInfoSelection = ((IEnumerable)totalPointsInfo.selection).Cast<dynamic>().ToList();
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
            var splitFraction = fraction.Split(new char[] { '/' });
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
            foreach (var sport in sports)
            {
                var boostUrl = $"https://sports.mtairycasino.foxbet.com/sportsbook/v1/api/getCouponCompetitions?slug={sport}-odds-boost-pa&channelId=15";
                var sportInformationJson = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(boostUrl).Result.ToString().Replace("event", "events"));
                var leagueListJson = ((IEnumerable)sportInformationJson).Cast<dynamic>();
                foreach (var leagueJson in leagueListJson)
                {
                    var gamesJson = ((IEnumerable)leagueJson.events).Cast<dynamic>();
                    foreach (var gameJson in gamesJson)
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

        public IEnumerable<PlayerPropOffering> AggregatePlayerProps()
        {
            var nflPlayerProps = GetPlayerProps(InitialFootballRequest, "NFL");
            var nbaPlayerProps = GetPlayerProps(InitialBasketballRequest, "NBA");

            return nflPlayerProps.Concat(nbaPlayerProps);
        }

        private IEnumerable<PlayerPropOffering> GetPlayerProps(string requestUrl, string sport)
        {
            var initialJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(requestUrl).Result);

            var usaCategoryJson = ((IEnumerable)initialJson.categories).Cast<dynamic>()
                .FirstOrDefault(g => g.name == "USA");

            if (usaCategoryJson == null)
                return Enumerable.Empty<PlayerPropOffering>();

            var sportCompetitionJson =
                ((IEnumerable)usaCategoryJson.competition).Cast<dynamic>().FirstOrDefault(g => g.name.Value.Contains(sport));
            if (sportCompetitionJson == null)
            {
                return Enumerable.Empty<PlayerPropOffering>();
            }
            var gamesUrl =
                $"https://sports.mtairycasino.foxbet.com/sportsbook/v1/api/getCompetitionEvents?competitionId={sportCompetitionJson.id}&includeOutrights=false&channelId=15&locale=en-us&siteId=134217728";
            var gamesJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(gamesUrl).Result).ToString()
                    .Replace("event", "events");

            var games = JsonConvert.DeserializeObject<dynamic>(gamesJson).events;
            var playerProps = new List<PlayerPropOffering>();
            foreach (var game in games)
            {
                var gamePlayerProps = ParsePlayerProps(game, sport, PlayerPropConstants.FoxBetProps[sport]);
                playerProps.AddRange(gamePlayerProps);
            }

            return playerProps;
        }

        private IEnumerable<PlayerPropOffering> ParsePlayerProps(dynamic game, string sport, List<PlayerPropDescriptions> props)
        {
            var participantList = ((IEnumerable)game.participants.participant).Cast<dynamic>().ToList();
            var homeTeam = participantList.Single(p => p.type == "HOME").names.longName;
            var awayTeam = participantList.Single(p => p.type == "AWAY").names.longName;

            if (sport == "NFL")
            {
                if (homeTeam == "Washington")
                    homeTeam = "Washington Football Team";
                else if (awayTeam == "Washington")
                    awayTeam = "Washington Football Team";
            }

            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddMilliseconds(Convert.ToDouble(game.eventsTime.Value));

            var gameId = game.id.Value.ToString();
            var playerPropUrl = $"https://sports.mtairycasino.foxbet.com/sportsbook/v1/api/getEvent?eventId={gameId}&channelId=15&locale=en-us&siteId=134217728";

            var playerPropJson =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(playerPropUrl).Result).ToString();

            var betOfferList = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(playerPropJson).markets).Cast<dynamic>();
            var playerProps = new List<PlayerPropOffering>();

            if (sport == "NBA")
                return ParseSeparatedProps(props, betOfferList, homeTeam, awayTeam, sport, dateTime);
            else
                return ParseGroupedProps(props, betOfferList, homeTeam, awayTeam, sport, dateTime);
        }

        private IEnumerable<PlayerPropOffering> ParseGroupedProps(List<PlayerPropDescriptions> props, IEnumerable<dynamic> betOfferList, dynamic homeTeam, dynamic awayTeam, string sport, dynamic dateTime)
        {
            var playerProps = new List<PlayerPropOffering>();
            foreach (var prop in props)
            {
                var propList = betOfferList.FirstOrDefault(b => b.name == prop.SiteDescription);

                if (propList == null)
                    continue;

                var propSelections = propList.selection;
                foreach (var propSelection in propSelections)
                {
                    if (propSelection.odds.frac.Value == "-" || (propSelection.displayed != null && propSelection.displayed.ToString().ToLower() == "false") || (propSelection.suspended != null && propSelection.suspended.ToString().ToLower() == "true"))
                        continue;

                    var playerProp = new PlayerPropOffering
                    {
                        Site = GetSportsBookName(),
                        HomeTeam = homeTeam,
                        AwayTeam = awayTeam,
                        Sport = sport,
                        DateTime = dateTime,
                        Payout = CalculateOdds(propSelection.odds.frac.Value),
                        PropValue = IsOverUnderBet(propSelection.names.longName) ? ParsePropValue(propSelection.names.longName) : null,
                        Description = prop.OurDescription,
                        OutcomeDescription = IsOverUnderBet(propSelection.names.longName) ? GetOverOrUnderDescription(propSelection.names.longName) : prop.OurOutcomeDescription
                    };

                    var attributes = ((IEnumerable)propSelection.attributes.attrib).Cast<dynamic>();
                    var teamValue = attributes.First(a => a.key.Value.ToString() == "playerTeam").value;
                    playerProp.PlayerName = attributes.First(a => a.key.Value.ToString() == "playerFirstName").value + " " + attributes.First(a => a.key.Value.ToString() == "playerLastName").value;

                    if (playerProp.PlayerName.ToLower().EndsWith("d/st"))
                    {
                        var onHomeTeam = teamValue == "HOME";
                        if (onHomeTeam)
                            playerProp.PlayerName = $"{homeTeam} D/ST";
                        else
                            playerProp.PlayerName = $"{awayTeam} D/ST";
                    }

                    playerProps.Add(playerProp);
                }
            }
            return playerProps;
        }

        private IEnumerable<PlayerPropOffering> ParseSeparatedProps(List<PlayerPropDescriptions> props, IEnumerable<dynamic> betOfferList, dynamic homeTeam, dynamic awayTeam, string sport, dynamic dateTime)
        {
            var playerProps = new List<PlayerPropOffering>();
            foreach (var prop in props)
            {
                var propList = betOfferList.Where(b => b.type == prop.SiteDescription);

                if (propList == null || !propList.Any())
                    continue;

                foreach(var propItem in propList)
                {
                    if (propItem.suspended != null && Convert.ToBoolean(propItem.suspended))
                        continue;
                    var propSelections = propItem.selection;
                    foreach (var propSelection in propSelections)
                    {
                        if (propSelection.odds.frac.Value == "-" || (propSelection.displayed != null && propSelection.displayed.ToString().ToLower() == "false") || (propSelection.suspended != null && propSelection.suspended.ToString().ToLower() == "true"))
                            continue;

                        var playerProp = new PlayerPropOffering
                        {
                            Site = GetSportsBookName(),
                            HomeTeam = homeTeam,
                            AwayTeam = awayTeam,
                            Sport = sport,
                            DateTime = dateTime,
                            Payout = CalculateOdds(propSelection.odds.frac.Value),
                            PropValue = IsOverUnderBet(propSelection.names.longName) ? ParsePropValue(propSelection.names.longName) : null,
                            Description = prop.OurDescription,
                            OutcomeDescription = IsOverUnderBet(propSelection.names.longName) ? GetOverOrUnderDescription(propSelection.names.longName) : prop.OurOutcomeDescription,
                            PlayerName = GetPlayerNameForSeparatedProps(propItem.name)
                        };

                        playerProps.Add(playerProp);
                    }
                }
            }
            return playerProps;
        }

        private string GetPlayerNameForSeparatedProps(dynamic propSelectionName)
        {
            var playerSelectionName = propSelectionName.ToString().Split(' ');
            if (playerSelectionName[0].Contains(","))
                return $"{playerSelectionName[1]} {playerSelectionName[0].Replace(",", "")}";
            else
                return $"{playerSelectionName[0]} {playerSelectionName[1]}";
        }

        private bool IsOverUnderBet(dynamic betName)
        {
            var betNameLower = betName.ToString().ToLower();

            //Note that this will not work if someone is named over or under
            return betNameLower.Contains(" over ") || betNameLower.Contains(" under ") || betNameLower.StartsWith("over ") || betNameLower.StartsWith("under ");
        }

        private double ParsePropValue(dynamic betName)
        {
            var betNameLower = betName.ToString().ToLower();
            int startIndex;
            if (betNameLower.Contains(" over ") || betNameLower.StartsWith("over "))
                startIndex = betNameLower.IndexOf("over ") + 5;
            else
                startIndex = betNameLower.IndexOf("under ") + 6;
            return double.Parse(betNameLower.Substring(startIndex));
        }

        private string GetOverOrUnderDescription(dynamic betName)
        {
            var betNameLower = betName.ToString().ToLower();
            if (betNameLower.Contains(" over ") || betNameLower.StartsWith("over "))
                return PlayerPropConstants.Over;
            else
                return PlayerPropConstants.Under;
        }
    }
}
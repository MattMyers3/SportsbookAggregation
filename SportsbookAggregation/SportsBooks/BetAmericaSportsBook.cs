using Newtonsoft.Json;
using SportsbookAggregation.Data.Models;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;

namespace SportsbookAggregation.SportsBooks
{
    public class BetAmericaSportsBook : ISportsBook
    {
        private const string urlToRetrieveBearerToken = "https://api-usp.sbtech.com/auth/v2/GetTokenBySiteId/15006";
        private const string GamesUrl =
            "https://api-pap.sbtech.com/betamericapa/sportscontent/sportsbook/v1/Events/GetByLeagueId";
        private const string OddsBoostUrl = "https://api-pap.sbtech.com/betamericapa/sportscontent/sportsbook/v1/Events/GetBySportId";

        public string GetSportsBookName()
        {
            return "BetAmerica";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var token = GetBearerToken();
            var basketballOfferings = GetBasketballOfferings(token);
            var nflOfferings = GetNFLOfferings(token);
            var baseballOfferings = GetBaseballOfferings(token);
            var ncaafOfferings = GetNCAAFOfferings(token);
            var ncaabOfferings = GetNCAABOfferings(token);
            Program.HttpClient = new HttpClient(); //Clear out state from parsing
            return ncaabOfferings.Concat(ncaafOfferings.Concat(baseballOfferings.Concat(basketballOfferings.Concat(nflOfferings))));
        }

        private string GetBearerToken()
        {
            return JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(urlToRetrieveBearerToken).Result).token;
        }

        private IEnumerable<GameOffering> GetBasketballOfferings(string token)
        {
            var requestJson = new StringContent("{\"eventState\":\"Mixed\",\"eventTypes\":[\"Fixture\",\"AggregateFixture\"],\"ids\":[\"42648\"],\"regionIds\":[\"227\"],\"marketTypeRequests\":[{\"sportIds\":[\"2\"],\"marketTypeIds\":[\"2_39\",\"1_39\",\"3_39\",\"2_0\",\"1_0\",\"3_0\"],\"statement\":\"Include\"}]}", Encoding.UTF8, "application/json-patch+json");
            return GetGameOfferings(token, requestJson, "Spread FT", "FT", "O/U FT");
        }

        private IEnumerable<GameOffering> GetNFLOfferings(string token)
        {
            var requestJson = new StringContent("{\"eventState\":\"Mixed\",\"eventTypes\":[\"Fixture\",\"AggregateFixture\"],\"ids\":[\"88808\"],\"regionIds\":[\"227\"],\"marketTypeRequests\":[{\"sportIds\":[\"3\"],\"marketTypeIds\":[\"2_39\",\"1_39\",\"3_39\",\"2_0\",\"1_0\",\"3_0\"],\"statement\":\"Include\"}]}", Encoding.UTF8, "application/json-patch+json");
            return GetGameOfferings(token, requestJson, "Spread FT", "Winner FT", "O/U FT");
        }

        private IEnumerable<GameOffering> GetNCAAFOfferings(string token)
        {
            var requestJson = new StringContent("{\"eventState\":\"Mixed\",\"eventTypes\":[\"Fixture\",\"AggregateFixture\"],\"ids\":[\"87637\"],\"regionIds\":[\"227\"],\"marketTypeRequests\":[{\"sportIds\":[\"3\"],\"marketTypeIds\":[\"2_39\",\"1_39\",\"3_39\",\"2_0\",\"1_0\",\"3_0\"],\"statement\":\"Include\"}]}", Encoding.UTF8, "application/json-patch+json");
            return GetGameOfferings(token, requestJson, "Spread FT", "Winner FT", "O/U FT");
        }

        private IEnumerable<GameOffering> GetNCAABOfferings(string token)
        {
            var requestJson = new StringContent("{\"eventState\":\"Mixed\",\"eventTypes\":[\"Fixture\",\"AggregateFixture\"],\"ids\":[\"92483\"],\"regionIds\":[\"227\"],\"marketTypeRequests\":[{\"sportIds\":[\"2\"],\"marketTypeIds\":[\"2_39\",\"1_39\",\"3_39\",\"2_0\",\"1_0\",\"3_0\"],\"statement\":\"Include\"}]}", Encoding.UTF8, "application/json-patch+json");
            return GetGameOfferings(token, requestJson, "Spread FT", "Moneyline FT", "O/U FT");
        }

        private IEnumerable<GameOffering> GetBaseballOfferings(string token)
        {
            var requestJson = new StringContent("{\"eventState\":\"Mixed\",\"eventTypes\":[\"Fixture\",\"AggregateFixture\"],\"ids\":[\"84240\"],\"regionIds\":[\"227\"],\"marketTypeRequests\":[{\"sportIds\":[\"7\"],\"marketTypeIds\":[\"2_39\",\"1_39\",\"3_39\",\"2_0\",\"1_0\",\"3_0\"],\"statement\":\"Include\"}]}", Encoding.UTF8, "application/json-patch+json");
            return GetGameOfferings(token, requestJson, "FT Run Line", "FT Money Line", "FT O/U Runs");
        }

        private dynamic GetGamesJson(string url, string token, StringContent requestJson)
        {
            Program.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Program.HttpClient.DefaultRequestHeaders.Host = "api-pap.sbtech.com";
            var responseJson = Program.HttpClient.PostAsync(url, requestJson).Result.Content.ReadAsStringAsync();
            var response = responseJson.Result.ToString().Replace("−", "-");//Not sure what this is. But it's not a minus sign. 
            return JsonConvert.DeserializeObject<dynamic>(response);
        }

        private IEnumerable<GameOffering> GetGameOfferings(string token, StringContent requestJson, string spreadLabel, string moneyLineLabel, string totalLabel)
        {
            var gamesJson = GetGamesJson(GamesUrl,token, requestJson);


            var eventInfo = ((IEnumerable)gamesJson.events).Cast<dynamic>();
            var gameInfo = ((IEnumerable)gamesJson.markets).Cast<dynamic>();
            var gameOfferings = new List<GameOffering>();
            foreach (var gameInfoJson in eventInfo)
            {
                var linesJson = gameInfo.Where(g => g.eventId == gameInfoJson.id);

                gameOfferings.Add(ParseGameOffering(gameInfoJson, linesJson, spreadLabel, moneyLineLabel,totalLabel));
            }

            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic gameInfoJson, dynamic linesJson, string spreadLabel, string moneyLineLabel, string totalLabel)
        {
            string awayTeam = ((IEnumerable)gameInfoJson.participants).Cast<dynamic>().FirstOrDefault(g => g.venueRole == "Away").name;
            string homeTeam = ((IEnumerable)gameInfoJson.participants).Cast<dynamic>().FirstOrDefault(g => g.venueRole == "Home").name;
            var gameOffering = new GameOffering
            {
                Site = GetSportsBookName(),
                Sport = gameInfoJson.leagueName,
                AwayTeam = LocationMapper.GetFullTeamName(awayTeam, gameInfoJson.leagueName.Value),
                HomeTeam = LocationMapper.GetFullTeamName(homeTeam, gameInfoJson.leagueName.Value),
                DateTime = gameInfoJson.startEventDate.Value
            };

            if (gameOffering.HomeTeam.Contains("Washington [NFL]"))
                gameOffering.HomeTeam = "Washington Football Team";
            if (gameOffering.AwayTeam.Contains("Washington [NFL]"))
                gameOffering.AwayTeam = "Washington Football Team";

            if (gameOffering.AwayTeam.Contains("[")) //Team name contains pitcher
            {
                gameOffering.AwayTeam = LocationMapper.GetFullTeamName(gameOffering.AwayTeam.Substring(0, gameOffering.AwayTeam.IndexOf("[")), gameOffering.Sport);
                gameOffering.HomeTeam = LocationMapper.GetFullTeamName(gameOffering.HomeTeam.Substring(0, gameOffering.HomeTeam.IndexOf("[")), gameOffering.Sport);
            }
            Regex gameRegex = new Regex(@"G\d.*");
            if(gameRegex.IsMatch(gameOffering.AwayTeam))
            {
                gameOffering.AwayTeam = LocationMapper.GetFullTeamName(gameOffering.AwayTeam.Substring(3), gameOffering.Sport);
                gameOffering.HomeTeam = LocationMapper.GetFullTeamName(gameOffering.HomeTeam.Substring(3), gameOffering.Sport);
            }

            var pointSpreadJson = ((IEnumerable)linesJson).Cast<dynamic>().FirstOrDefault(g => g.name == spreadLabel);
            var totalPointsJson = ((IEnumerable)linesJson).Cast<dynamic>().FirstOrDefault(g => g.name == totalLabel);
            var moneylineJson = ((IEnumerable)linesJson).Cast<dynamic>().FirstOrDefault(g => g.name == moneyLineLabel);

            if (pointSpreadJson != null)
            {
                var homeSelection = ((IEnumerable)pointSpreadJson.selections).Cast<dynamic>().FirstOrDefault(g => g.outcomeType == "Home");
                var awaySelection = ((IEnumerable)pointSpreadJson.selections).Cast<dynamic>().FirstOrDefault(g => g.outcomeType == "Away");
                gameOffering.CurrentSpread = homeSelection.points.Value;
                gameOffering.HomeSpreadPayout = Convert.ToInt32(homeSelection.displayOdds.american.Value);
                gameOffering.AwaySpreadPayout = Convert.ToInt32(awaySelection.displayOdds.american.Value);
            }

            if (moneylineJson != null)
            {
                var homeSelection = ((IEnumerable)moneylineJson.selections).Cast<dynamic>().FirstOrDefault(g => g.outcomeType == "Home");
                var awaySelection = ((IEnumerable)moneylineJson.selections).Cast<dynamic>().FirstOrDefault(g => g.outcomeType == "Away");
                gameOffering.HomeMoneyLinePayout = Convert.ToInt32(homeSelection.displayOdds.american.Value);
                gameOffering.AwayMoneyLinePayout = Convert.ToInt32(awaySelection.displayOdds.american.Value);
            }

            if (totalPointsJson != null)
            {
                var overSelection = ((IEnumerable)totalPointsJson.selections).Cast<dynamic>().FirstOrDefault(g => g.outcomeType == "Over");
                var underSelection = ((IEnumerable)totalPointsJson.selections).Cast<dynamic>().FirstOrDefault(g => g.outcomeType == "Under");
                gameOffering.CurrentOverUnder = overSelection.points.Value;
                gameOffering.OverPayOut = Convert.ToInt32(overSelection.displayOdds.american.Value);
                gameOffering.UnderPayout = Convert.ToInt32(underSelection.displayOdds.american.Value);
            }

            return gameOffering;
        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            var token = GetBearerToken();
            var requestJson = new StringContent("{\"eventState\":\"Mixed\",\"eventTypes\":[\"Outright\"],\"ids\":[\"201\"],\"eventTags\":[],\"leagueState\":\"Regular\",\"pagination\":{\"top\":100,\"skip\":0}}", Encoding.UTF8, "application/json-patch+json");
            var oddsBoostJson = GetGamesJson(OddsBoostUrl, token, requestJson);

            var oddsBoosts = new List<OddsBoostOffering>();
            var eventsInfo = ((IEnumerable)oddsBoostJson.markets).Cast<dynamic>();
            foreach (var eventInfo in eventsInfo)
            {
                var nameSplit = eventInfo.name.ToString().Split(new string[] { "(Was ", "(was " }, StringSplitOptions.None);
                var oddsBoost = new OddsBoostOffering();
                oddsBoost.BoostedOdds = Convert.ToInt32(eventInfo.selections[0].displayOdds.american);
                oddsBoost.Date = eventInfo.startDate;
                oddsBoost.Description = $"({nameSplit[0]}) {eventInfo.selections[0].name}";
                oddsBoost.PreviousOdds = Convert.ToInt32(nameSplit[1].ToString().Substring(0, nameSplit[1].IndexOf(')')));
                oddsBoost.Site = GetSportsBookName();
                oddsBoosts.Add(oddsBoost);
            }

            Program.HttpClient = new HttpClient(); //Clear out state from parsing
            return oddsBoosts;
        }

        public IEnumerable<PlayerPropOffering> AggregatePlayerProps()
        {
            throw new NotImplementedException();
        }
    }
}

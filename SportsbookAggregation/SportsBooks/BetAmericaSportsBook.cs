using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace SportsbookAggregation.SportsBooks
{
    public class BetAmericaSportsBook : ISportsBook
    {
        private const string urlToRetrieveBearerToken = "https://api-usp.sbtech.com/auth/v2/GetTokenBySiteId/15006";
        private const string RequestUrl =
            "https://api-pap.sbtech.com/betamericapa/sportscontent/sportsbook/v1/Events/GetByLeagueId";

        public string GetSportsBookName()
        {
            return "BetAmerica";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var token = GetBearerToken();
            var basketballOfferings = GetBasketballOfferings(token);
            var footballOfferings = GetFootballOfferings(token);
           // Program.HttpClient = new HttpClient(); //Clear out everything from parsing
            return basketballOfferings.Concat(footballOfferings);
        }

        private string GetBearerToken()
        {
            return JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(urlToRetrieveBearerToken).Result).token;
        }

        private IEnumerable<GameOffering> GetBasketballOfferings(string token)
        {
            var requestJson = new StringContent("{\"eventState\":\"Mixed\",\"eventTypes\":[\"Fixture\",\"AggregateFixture\"],\"ids\":[\"42648\"],\"regionIds\":[\"227\"],\"marketTypeRequests\":[{\"sportIds\":[\"2\"],\"marketTypeIds\":[\"2_39\",\"1_39\",\"3_39\",\"2_0\",\"1_0\",\"3_0\"],\"statement\":\"Include\"}]}", Encoding.UTF8, "application/json-patch+json");
            return GetGameOfferings(token, requestJson);
        }

        private IEnumerable<GameOffering> GetFootballOfferings(string token)
        {
            var requestJson = new StringContent("{\"eventState\":\"Mixed\",\"eventTypes\":[\"Fixture\",\"AggregateFixture\"],\"ids\":[\"88808\"],\"regionIds\":[\"227\"],\"marketTypeRequests\":[{\"sportIds\":[\"3\"],\"marketTypeIds\":[\"2_39\",\"1_39\",\"3_39\",\"2_0\",\"1_0\",\"3_0\"],\"statement\":\"Include\"}]}", Encoding.UTF8, "application/json-patch+json");
            return GetGameOfferings(token, requestJson);
        }

        private dynamic GetGamesJson(string token, StringContent requestJson)
        {
            Program.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Program.HttpClient.DefaultRequestHeaders.Host = "api-pap.sbtech.com";
            var responseJson = Program.HttpClient.PostAsync(RequestUrl, requestJson).Result.Content.ReadAsStringAsync();
            var response = responseJson.Result.ToString().Replace("−", "-");
            return JsonConvert.DeserializeObject<dynamic>(response);
        }

        private IEnumerable<GameOffering> GetGameOfferings(string token, StringContent requestJson)
        {
            var gamesJson = GetGamesJson(token, requestJson);


            var eventInfo = ((IEnumerable)gamesJson.events).Cast<dynamic>();
            var gameInfo = ((IEnumerable)gamesJson.markets).Cast<dynamic>();
            var gameOfferings = new List<GameOffering>();
            foreach (var gameInfoJson in eventInfo)
            {
                var linesJson = gameInfo.Where(g => g.eventId == gameInfoJson.id);

                gameOfferings.Add(ParseGameOffering(gameInfoJson, linesJson));
            }

            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic gameInfoJson, dynamic linesJson)
        {
            var gameOffering = new GameOffering
            {
                Site = GetSportsBookName(),
                Sport = gameInfoJson.leagueName,
                AwayTeam = ((IEnumerable)gameInfoJson.participants).Cast<dynamic>().FirstOrDefault(g => g.venueRole == "Away").name,
                HomeTeam = ((IEnumerable)gameInfoJson.participants).Cast<dynamic>().FirstOrDefault(g => g.venueRole == "Home").name,
                DateTime = gameInfoJson.startEventDate.Value.AddHours(-4)
            };

            var pointSpreadJson = ((IEnumerable)linesJson).Cast<dynamic>().FirstOrDefault(g => g.name == "FT Spread");
            var totalPointsJson = ((IEnumerable)linesJson).Cast<dynamic>().FirstOrDefault(g => g.name == "FT O/U");
            var moneylineJson = ((IEnumerable)linesJson).Cast<dynamic>().FirstOrDefault(g => g.name == "FT Winner" || g.name == "FT Moneyline");

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
    }
}

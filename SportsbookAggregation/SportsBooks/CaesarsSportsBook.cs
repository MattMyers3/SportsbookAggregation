﻿using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace SportsbookAggregation.SportsBooks
{
    public class CaesarsSportBook : ISportsBook
    {
        private const string NbaCode = "72";
        private const string NflCode = "55";
        private const string NhlCode = "87";
        private const string NcaafCode = "58";
        private const string NcaabCode = "76";


        public string GetSportsBookName()
        {
            return "Caesars";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings() //make sure you are on pa.caesarsonline.com
        {
            Program.HttpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.146 Safari/537.36");
            Program.HttpClient.DefaultRequestHeaders.Add("authority", "sb-content.pa.caesarsonline.com");
            Program.HttpClient.DefaultRequestHeaders.Add("scheme", "https");
            Program.HttpClient.DefaultRequestHeaders.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            Program.HttpClient.DefaultRequestHeaders.Add("accept-language", "en-US,en;q=0.9");
            Program.HttpClient.DefaultRequestHeaders.Add("cache-control", "max-age=0");
            Program.HttpClient.DefaultRequestHeaders.Add("sec-ch-ua", "\"Chromium\";v=\"88\", \"Google Chrome\";v=\"88\", \"; Not A Brand\";v=\"99\"");
            Program.HttpClient.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
            Program.HttpClient.DefaultRequestHeaders.Add("sec-fetch-dest", "document");
            Program.HttpClient.DefaultRequestHeaders.Add("sec-fetch-mode", "navigate");
            Program.HttpClient.DefaultRequestHeaders.Add("sec-fetch-site", "none");
            Program.HttpClient.DefaultRequestHeaders.Add("sec-fetch-user", "?1");
            Program.HttpClient.DefaultRequestHeaders.Add("upgrade-insecure-requests", "1");

            IEnumerable<GameOffering> offerings = new List<GameOffering>();
            if (Program.Configuration.ShouldParseSport("NFL"))
                offerings = offerings.Concat(GetFootballOfferings());
            if (Program.Configuration.ShouldParseSport("NBA"))
                offerings = offerings.Concat(GetBasketballOfferings());
            if (Program.Configuration.ShouldParseSport("NHL"))
                offerings = offerings.Concat(GetHockeyOfferings());
            if (Program.Configuration.ShouldParseSport("NCAAB"))
                offerings = offerings.Concat(GetNCAABOfferings());
            if (Program.Configuration.ShouldParseSport("NCAAF"))
                offerings = offerings.Concat(GetNCAAFOfferings());

            Program.HttpClient.DefaultRequestHeaders.Remove("user-agent");
            Program.HttpClient.DefaultRequestHeaders.Remove("authority");
            Program.HttpClient.DefaultRequestHeaders.Remove("scheme");
            Program.HttpClient.DefaultRequestHeaders.Remove("accept");
            Program.HttpClient.DefaultRequestHeaders.Remove("accept-language");
            Program.HttpClient.DefaultRequestHeaders.Remove("cache-control");
            Program.HttpClient.DefaultRequestHeaders.Remove("sec-ch-ua");
            Program.HttpClient.DefaultRequestHeaders.Remove("sec-ch-ua-mobile");
            Program.HttpClient.DefaultRequestHeaders.Remove("sec-fetch-dest");
            Program.HttpClient.DefaultRequestHeaders.Remove("sec-fetch-mode");
            Program.HttpClient.DefaultRequestHeaders.Remove("sec-fetch-site");
            Program.HttpClient.DefaultRequestHeaders.Remove("sec-fetch-user");
            Program.HttpClient.DefaultRequestHeaders.Remove("upgrade-insecure-requests");

            return offerings;
        }

        private IEnumerable<GameOffering> GetBasketballOfferings()
        {
            return GetGameOfferings(NbaCode, "NBA", "Point Spread", "Money Line", "Total Points Over/Under");
        }

        private IEnumerable<GameOffering> GetHockeyOfferings()
        {
            return GetGameOfferings(NhlCode, "NHL", "Puck Line", "Money Line", "Total Goals Over/Under");
        }

        private IEnumerable<GameOffering> GetFootballOfferings()
        {
            return GetGameOfferings(NflCode, "NFL", "Spread", "Money Line", "Total Points Over/Under");
        }

        private IEnumerable<GameOffering> GetNCAAFOfferings()
        {
            return GetGameOfferings(NcaafCode, "NCAAF", "Point Spread", "Money Line", "Total Points Over/Under");
        }

        private IEnumerable<GameOffering> GetNCAABOfferings()
        {
            return GetGameOfferings(NcaabCode, "NCAAB", "Point Spread", "Money Line", "Total Points Over/Under");
        }

        private string GetSportsUrl(string sportsCode)
        {
            return $"https://sb-content.pa.caesarsonline.com/content-service/api/v1/q/event-list?started=false&active=true&marketSortsIncluded=HH%2CHL%2CMR%2CWH&eventSortsIncluded=MTCH&includeChildMarkets=true&drilldownTagIds={sportsCode}";
        }

        private IEnumerable<GameOffering> GetGameOfferings(string sportsCode, string sportName, string spreadName, string moneyLineName, string overUnderName)
        {
            var responseString =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(GetSportsUrl(sportsCode)).Result);

            var games = ((IEnumerable)responseString.data.events).Cast<dynamic>();
            var gameOfferings = new List<GameOffering>();
            foreach (var game in games)
            {
                gameOfferings.Add(ParseGameOffering(game, sportName, spreadName, moneyLineName, overUnderName));
            }

            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic game, string sportName, string spreadName, string moneyLineName, string overUnderName)
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

            var pointSpreadJson = markets.FirstOrDefault(g => g.name == spreadName);
            var totalPointsJson = markets.FirstOrDefault(g => g.name == overUnderName);
            var moneylineJson = markets.FirstOrDefault(g => g.name == moneyLineName);

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

        public IEnumerable<PlayerPropOffering> AggregatePlayerProps()
        {
            return Enumerable.Empty<PlayerPropOffering>();
        }
    }
}

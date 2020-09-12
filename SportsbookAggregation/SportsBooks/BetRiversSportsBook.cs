using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SportsbookAggregation.SportsBooks
{
    public class BetRiversSportsBook : ISportsBook
    {
        private const string InitialRequest = "https://pa.betrivers.com/?l=RiversPittsburgh&page=sportsbook&feed=featured";

        public string GetSportsBookName()
        {
            return "BetRivers";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var initialResponse = Program.HttpClient.GetStringAsync(InitialRequest).Result;
            var hashVersion = Regex.Match(initialResponse, "\"hashVersion\": \"(.*)\"").Groups[1].Value;

            var offeringsUrl = $"https://pa.betrivers.com/conf/cache.js?cv={hashVersion}";
            const string trimString = "window.args = ";
            var offeringsJsonText = TrimStart(Program.HttpClient.GetStringAsync(offeringsUrl).Result, trimString).TrimEnd(';');
            var offeringsJson = JsonConvert.DeserializeObject<dynamic>(offeringsJsonText);

            return GetBasketballOfferings(offeringsJson);
        }

        private IEnumerable<GameOffering> GetBasketballOfferings(dynamic offeringsJson)
        {
            var nbaApiKey = ((IEnumerable)offeringsJson.eventViews.views).Cast<dynamic>()
               .First(g => g.slug == "basketball_nba").sections[0].apiKey.Value;

            var nbaOfferingsUrl = $"https://pa.betrivers.com/api/service/sportsbook/offering/feed?key={nbaApiKey}";
            var nbaOfferingsJson = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(nbaOfferingsUrl).Result).events;

            return GetNbaGameOfferings(nbaOfferingsJson);
        }

        private IEnumerable<GameOffering> GetNbaGameOfferings(dynamic nbaOfferingsJson)
        {
            var gameOfferings = new List<GameOffering>();
            foreach (var nbaOffering in nbaOfferingsJson)
            {
                var offering = ParseNbaGameOffering(nbaOffering);
                if (offering != null)
                    gameOfferings.Add(offering);
            }
            return gameOfferings;
        }

        private GameOffering ParseNbaGameOffering(dynamic gameJson)
        {
            var gameOffering = new GameOffering
            {
                Site = GetSportsBookName(),
                AwayTeam = GetFullTeamName(gameJson.participants[1].name.Value),
                HomeTeam = GetFullTeamName(gameJson.participants[0].name.Value),
                Sport = gameJson.eventInfo[1].name,
                DateTime = gameJson.start.Value.AddHours(-4)
            };

            var pointSpreadJson = ((IEnumerable)gameJson.betOffers).Cast<dynamic>().FirstOrDefault(g => g.betDescription == "Point Spread");
            var totalPointsJson = ((IEnumerable)gameJson.betOffers).Cast<dynamic>().FirstOrDefault(g => g.betDescription == "Total Points");
            var moneylineJson = ((IEnumerable)gameJson.betOffers).Cast<dynamic>().FirstOrDefault(g => g.betDescription == "Moneyline");

            if (pointSpreadJson == null && totalPointsJson == null && moneylineJson == null)
                return null;

            if (pointSpreadJson != null)
            {
                gameOffering.CurrentSpread = pointSpreadJson.outcomes[0].line.Value;
                gameOffering.HomeSpreadPayout = Convert.ToInt32(pointSpreadJson.outcomes[0].oddsAmerican.Value);
                gameOffering.AwaySpreadPayout = Convert.ToInt32(pointSpreadJson.outcomes[1].oddsAmerican.Value);
            }

            if (moneylineJson != null)
            {
                gameOffering.HomeMoneyLinePayout = Convert.ToInt32(moneylineJson.outcomes[0].oddsAmerican.Value);
                gameOffering.AwayMoneyLinePayout = Convert.ToInt32(moneylineJson.outcomes[1].oddsAmerican.Value);
            }

            if (totalPointsJson != null)
            {
                gameOffering.CurrentOverUnder = totalPointsJson.outcomes[0].line.Value;
                gameOffering.OverPayOut = Convert.ToInt32(totalPointsJson.outcomes[0].oddsAmerican.Value);
                gameOffering.UnderPayout = Convert.ToInt32(totalPointsJson.outcomes[1].oddsAmerican.Value);
            }

            return gameOffering;
        }

        private static string GetFullTeamName(string shortTeamName)
        {
            var teamNameArray = shortTeamName.Split(' ');
            var location = MapLocation(teamNameArray[0]);
            return $"{location}{shortTeamName.Substring(teamNameArray[0].Length)}";
        }

        private static string MapLocation(string abbreviation)
        {
            switch(abbreviation.ToUpper())
            {
                case "ATL":
                    return "Atlanta";
                case "BOS":
                    return "Boston";
                case "BKN":
                    return "Brooklyn";
                case "CHA":
                    return "Charlotte";
                case "CHI":
                    return "Chicago";
                case "CLE":
                    return "Cleveland";
                case "DAL":
                    return "Dallas";
                case "DEN":
                    return "Denver";
                case "DET":
                    return "Detroit";
                case "GS":
                    return "Golden State";
                case "HOU":
                    return "Houston";
                case "IND":
                    return "Indiana";
                case "LA":
                    return "Los Angeles";
                case "MEM":
                    return "Memphis";
                case "MIA":
                    return "Miami";
                case "MIL":
                    return "Milwaukee";
                case "MIN":
                    return "Minnesota";
                case "NO":
                    return "New Orleans";
                case "NY":
                    return "New York";
                case "OKC":
                    return "Oklahoma City";
                case "ORL":
                    return "Orlando";
                case "PHI":
                    return "Philadelphia";
                case "PHX":
                    return "Phoenix";
                case "POR":
                    return "Portland";
                case "SAC":
                    return "Sacramento";
                case "SA":
                    return "San Antonio";
                case "TOR":
                    return "Toronto";
                case "UTA":
                    return "Utah";
                case "WAS":
                    return "Washington";
                default:
                    throw new Exception("Unable to find location.");

            }
        }

        private static string TrimStart(string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString)) return target;

            string result = target;
            while (result.StartsWith(trimString))
            {
                result = result.Substring(trimString.Length);
            }

            return result;
        }
    }
}

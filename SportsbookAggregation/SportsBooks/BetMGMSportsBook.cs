using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace SportsbookAggregation.SportsBooks
{
    public class BetMGMSportsBook : ISportsBook
    {
        private const string urlToRetrieveAccessToken = "https://sports.pa.betmgm.com/en/api/clientconfig";
        private const int nflSportsId = 11;
        private const int basketballSportsId = 7;
        private string token; 
        private string baseUrl;

        public string GetSportsBookName()
        {
            return "BetMGM";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            SetTokenAndBaseUrl();
            var nbaOfferings = GetGameOfferings(basketballSportsId, "NBA", "NBA");
            var nflOfferings = GetGameOfferings(nflSportsId, "NFL", "NFL");
            var ncaafOfferings = GetGameOfferings(nflSportsId, "College Football ", "NCAAF"); //The space is not a typo.
            var ncaabOfferings = GetGameOfferings(basketballSportsId, "NCAA ", "NCAAB"); // The space is not a typo.
            return nbaOfferings.Concat(nflOfferings.Concat(ncaafOfferings.Concat(ncaabOfferings)));
        }

        private void SetTokenAndBaseUrl()
        {
            var msConnection = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(urlToRetrieveAccessToken).Result).msConnection;
            token = msConnection.publicAccessId;
            baseUrl = msConnection.cdsUrlBase;
        }

        private dynamic GetGamesJson(int sportsId)
        {
            var url = $"{baseUrl}/bettingoffer/fixtures?x-bwin-accessid={token}&lang=en-us&country=US&userCountry=US&fixtureTypes=Standard&state=Latest&offerMapping=Filtered&offerCategories=Gridable&sportIds={sportsId}";
            return JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(url).Result).fixtures;
        }

        private IEnumerable<GameOffering> GetGameOfferings(int sportsId, string betMGMSportsName, string ourSportsName)
        {
            var gamesJson = GetGamesJson(sportsId);
            var gamesInfo = ((IEnumerable)gamesJson).Cast<dynamic>().Where(g => g.competition.name.value == betMGMSportsName && Convert.ToBoolean(g.isOpenForBetting) && g.games.Count != 0);
            var gameOfferings = new List<GameOffering>();
            foreach (var gameInfoJson in gamesInfo)
            {
                gameOfferings.Add(ParseGameOffering(gameInfoJson, ourSportsName));
            }

            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic gameInfoJson, string ourSportsName)
        {
            string awayTeam = gameInfoJson.participants[0].name.value;
            string homeTeam = gameInfoJson.participants[1].name.value;

            var gameOffering = new GameOffering
            {
                Site = GetSportsBookName(),
                AwayTeam = awayTeam.Trim(),
                HomeTeam = homeTeam.Trim(),
                Sport = ourSportsName,
                DateTime = gameInfoJson.startDate
            };

            var betListJson = ((IEnumerable)gameInfoJson.games).Cast<dynamic>();

            var moneylineJson = ((IEnumerable)betListJson).Cast<dynamic>().FirstOrDefault(g => g.name.value == "Money Line");
            var pointSpreadOptions = ((IEnumerable)betListJson).Cast<dynamic>().Where(g => g.name.value == "Spread");            
            var totalPointsOptions = ((IEnumerable)betListJson).Cast<dynamic>().Where(g => g.name.value == "Totals");
            var pointSpreadJson = pointSpreadOptions.Count() != 0 ? pointSpreadOptions.Aggregate((i1, i2) => i1.spread < i2.spread ? i1 : i2) : null;//https://stackoverflow.com/questions/3188693/how-can-i-get-linq-to-return-the-object-which-has-the-max-value-for-a-given-prop
            var totalPointsJson = totalPointsOptions.Count() != 0 ? totalPointsOptions.Aggregate((i1, i2) => i1.spread < i2.spread ? i1 : i2) : null;//We want the game with the lowest "spread". That's the displayed line.

            if (pointSpreadJson != null)
            {
                gameOffering.CurrentSpread = pointSpreadJson.results[1].attr;
                gameOffering.HomeSpreadPayout = Convert.ToInt32(pointSpreadJson.results[1].americanOdds);
                gameOffering.AwaySpreadPayout = Convert.ToInt32(pointSpreadJson.results[0].americanOdds);
            }

            if (moneylineJson != null)
            {
                gameOffering.HomeMoneyLinePayout = Convert.ToInt32(moneylineJson.results[1].americanOdds);
                gameOffering.AwayMoneyLinePayout = Convert.ToInt32(moneylineJson.results[0].americanOdds);
            }

            if (totalPointsJson != null)
            {
                var overSelection = ((IEnumerable)totalPointsJson.results).Cast<dynamic>().FirstOrDefault(g => g.totalsPrefix == "Over");
                var underSelection = ((IEnumerable)totalPointsJson.results).Cast<dynamic>().FirstOrDefault(g => g.totalsPrefix == "Under");
                gameOffering.CurrentOverUnder = totalPointsJson.attr;
                gameOffering.OverPayOut = Convert.ToInt32(overSelection.americanOdds);
                gameOffering.UnderPayout = Convert.ToInt32(underSelection.americanOdds);
            }

            return gameOffering;
        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            SetTokenAndBaseUrl();
            var marqueeTiles = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(urlToRetrieveAccessToken).Result).msMarqueeTiles.marqueeTiles;
            var lionsBoostFixtureId = ((IEnumerable)marqueeTiles).Cast<dynamic>().Single(m => m.badgeTitleOverride == "Lion's Boost").fixtureId;

            var urlForLionsBoost = $"{baseUrl}/bettingoffer/fixture-view?x-bwin-accessid={token}&lang=en-us&country=US&userCountry=US&offerMapping=All&scoreboardMode=Full&fixtureIds={lionsBoostFixtureId}&state=Latest&includePrecreatedBetBuilder=true&supportVirtual=false";
            var lionsBoostJson = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(urlForLionsBoost).Result).fixture;

            var lionsBoost = new OddsBoostOffering();
            lionsBoost.BoostedOdds = lionsBoostJson.games[0].results[0].americanOdds;
            lionsBoost.Date = lionsBoostJson.startDate;
            lionsBoost.Description = lionsBoostJson.games[0].results[0].name.value;
            lionsBoost.Site = GetSportsBookName();

            return new List<OddsBoostOffering>() { lionsBoost };
        }
    }
}

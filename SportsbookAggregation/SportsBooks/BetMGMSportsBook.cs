using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            SetRequestHeaders();

            SetTokenAndBaseUrl();
            IEnumerable<GameOffering> offerings = new List<GameOffering>();
            if (Program.Configuration.ShouldParseSport("NFL"))
                offerings = offerings.Concat(GetGameOfferings(nflSportsId, "NFL", "NFL"));
            if (Program.Configuration.ShouldParseSport("NBA"))
                offerings = offerings.Concat(GetGameOfferings(basketballSportsId, "NBA", "NBA"));
            if (Program.Configuration.ShouldParseSport("NCAAB"))
                offerings = offerings.Concat(GetGameOfferings(basketballSportsId, "NCAA ", "NCAAB"));
            if (Program.Configuration.ShouldParseSport("NCAAF"))
                offerings = offerings.Concat(GetGameOfferings(nflSportsId, "College Football ", "NCAAF"));

            RemoveRequestHeaders();

            return offerings;
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
            SetRequestHeaders();
            SetTokenAndBaseUrl();
            var marqueeTiles = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(urlToRetrieveAccessToken).Result).msMarquee.tiles;
            var lionsBoosts = ((IEnumerable)marqueeTiles).Cast<dynamic>().Where(m => m.badgeTitleOverride == "Lion's Boost");
            var oddsBoosts = new List<OddsBoostOffering>();
            foreach(var lionsBoost in lionsBoosts)
            {
                var lionsBoostFixtureId = lionsBoost.fixtureId;

                var urlForLionsBoost = $"{baseUrl}/bettingoffer/fixture-view?x-bwin-accessid={token}&lang=en-us&country=US&userCountry=US&offerMapping=All&scoreboardMode=Full&fixtureIds={lionsBoostFixtureId}&state=Latest&includePrecreatedBetBuilder=true&supportVirtual=false";
                var lionsBoostJson = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(urlForLionsBoost).Result).fixture;

                if (lionsBoostJson == null)
                    continue;

                var lionsBoostOffering = new OddsBoostOffering();
                lionsBoostOffering.BoostedOdds = lionsBoostJson.games[0].results[0].americanOdds;
                lionsBoostOffering.Date = lionsBoostJson.startDate;
                lionsBoostOffering.Description = lionsBoostJson.games[0].results[0].name.value;
                lionsBoostOffering.Site = GetSportsBookName();

                oddsBoosts.Add(lionsBoostOffering);
            }
            RemoveRequestHeaders();

            return oddsBoosts;
        }

        public IEnumerable<PlayerPropOffering> AggregatePlayerProps()
        {
            return Enumerable.Empty<PlayerPropOffering>();
        }

        private void SetRequestHeaders()
        {
            Program.HttpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.146 Safari/537.36");
            Program.HttpClient.DefaultRequestHeaders.Add("authority", "cds-api.pa.betmgm.com");
            Program.HttpClient.DefaultRequestHeaders.Add("scheme", "https");
            Program.HttpClient.DefaultRequestHeaders.Add("accept", "application/json, text/plain, */*");
            Program.HttpClient.DefaultRequestHeaders.Add("accept-language", "en-US,en;q=0.9");
            Program.HttpClient.DefaultRequestHeaders.Add("sec-ch-ua", "\"Chromium\";v=\"88\", \"Google Chrome\";v=\"88\", \"; Not A Brand\";v=\"99\"");
            Program.HttpClient.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
            Program.HttpClient.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
            Program.HttpClient.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
            Program.HttpClient.DefaultRequestHeaders.Add("sec-fetch-site", "same-site");
        }

        private void RemoveRequestHeaders()
        {
            Program.HttpClient.DefaultRequestHeaders.Remove("user-agent");
            Program.HttpClient.DefaultRequestHeaders.Remove("authority");
            Program.HttpClient.DefaultRequestHeaders.Remove("scheme");
            Program.HttpClient.DefaultRequestHeaders.Remove("accept");
            Program.HttpClient.DefaultRequestHeaders.Remove("accept-language");
            Program.HttpClient.DefaultRequestHeaders.Remove("sec-ch-ua");
            Program.HttpClient.DefaultRequestHeaders.Remove("sec-ch-ua-mobile");
            Program.HttpClient.DefaultRequestHeaders.Remove("sec-fetch-dest");
            Program.HttpClient.DefaultRequestHeaders.Remove("sec-fetch-mode");
            Program.HttpClient.DefaultRequestHeaders.Remove("sec-fetch-site");
        }
    }
}

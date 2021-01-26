using Newtonsoft.Json;
using SportsbookAggregation.Constants;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SportsbookAggregation.SportsBooks.OddsProviders
{
    class KambicdnOddsProvider
    {
        private readonly string site;
        private readonly string NbaRequestUrl;
        private readonly string NflRequestUrl;
        private readonly string MlbRequestUrl;
        private readonly string NcaafRequestUrl;
        private readonly string NcaabRequestUrl;
        private readonly string OddsBoostUrl;
        private readonly string BaseUrl;



        public KambicdnOddsProvider(string sportsbook, string siteRouteName, string siteSpecialsName)
        {
            site = sportsbook;
            BaseUrl = $"https://eu-offering.kambicdn.org/offering/v2018/{siteRouteName}";
            NbaRequestUrl = BaseUrl + $"/listView/basketball/nba.json?lang=en_US&market=US&useCombined=true";
            NflRequestUrl = BaseUrl + $"/listView/american_football/nfl.json?lang=en_US&market=US&useCombined=true";
            MlbRequestUrl = BaseUrl + $"/listView/baseball/mlb.json?lang=en_US&market=US&useCombined=true";
            NcaafRequestUrl = BaseUrl + $"/listView/american_football/ncaaf.json?lang=en_US&market=US&useCombined=true";
            NcaabRequestUrl = BaseUrl + $"/listView/basketball/ncaab.json?lang=en_US&market=US&useCombined=true";
            OddsBoostUrl = BaseUrl + $"/listView/{siteSpecialsName}.json?lang=en_US&market=US&&useCombined=true";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            IEnumerable<GameOffering> offerings = new List<GameOffering>();
            if (Program.Configuration.ShouldParseSport("NFL"))
                offerings = offerings.Concat(GetNFLOfferings());
            if (Program.Configuration.ShouldParseSport("NBA"))
                offerings = offerings.Concat(GetBasketballOfferings());
            if (Program.Configuration.ShouldParseSport("MLB"))
                offerings = offerings.Concat(GetBaseballOfferings());
            if (Program.Configuration.ShouldParseSport("NCAAB"))
                offerings = offerings.Concat(GetNCAABOfferings());
            if (Program.Configuration.ShouldParseSport("NCAAF"))
                offerings = offerings.Concat(GetNCAAFOfferings());

            return offerings;
        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            var oddsBoostOfferings = new List<OddsBoostOffering>();
            var requestString =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(OddsBoostUrl).Result).ToString().Replace("event", "Event"); //needed because event is a C# key word
            var eventList = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(requestString).Events).Cast<dynamic>();
            foreach (var eventObject in eventList)
            {
                var eventId = eventObject.Event.id;
                var url = BaseUrl + $"/betoffer/event/{eventId}.json?lang=en_US&market=US&includeParticipants=true";

                var betOfferResponse = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(url).Result).ToString();//needed because event is a C# key word
                var betOfferList = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(betOfferResponse).betOffers).Cast<dynamic>();
                foreach (var betOffer in betOfferList)
                {
                    var oddsBoost = new OddsBoostOffering();
                    oddsBoost.Description = betOffer.criterion.englishLabel;
                    oddsBoost.BoostedOdds = ((IEnumerable)betOffer.outcomes).Cast<dynamic>().FirstOrDefault(g => g.status == "OPEN").oddsAmerican;
                    oddsBoost.Site = site;
                    oddsBoost.Date = betOffer.closed;
                    oddsBoostOfferings.Add(oddsBoost);
                }
            }
            return oddsBoostOfferings;
        }

        private IEnumerable<GameOffering> GetBasketballOfferings()
        {
            return GetGameOfferings(NbaRequestUrl, "Point Spread", "Moneyline", "Total Points");
        }

        private IEnumerable<GameOffering> GetNFLOfferings()
        {
            return GetGameOfferings(NflRequestUrl, "Point Spread", "Moneyline", "Total Points");
        }

        private IEnumerable<GameOffering> GetBaseballOfferings()
        {
            return GetGameOfferings(MlbRequestUrl, "Run Line", "Moneyline", "Total Runs");
        }

        private IEnumerable<GameOffering> GetNCAAFOfferings()
        {
            return GetGameOfferings(NcaafRequestUrl, "Point Spread", "Moneyline", "Total Points");
        }

        private IEnumerable<GameOffering> GetNCAABOfferings()
        {
            return GetGameOfferings(NcaabRequestUrl, "Point Spread", "Moneyline", "Total Points");
        }

        private IEnumerable<GameOffering> GetGameOfferings(string sportRequestUrl, string spreadLabel, string moneyLineLabel, string totalLabel)
        {
            var requestString =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(sportRequestUrl).Result).ToString().Replace("event", "Event"); //needed because event is a C# key word

            var games = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(requestString).Events).Cast<dynamic>();
            var gameOfferings = new List<GameOffering>();
            foreach (var game in games)
            {
                var eventInfo = game.Event;
                var betOffers = game.betOffers;

                if (eventInfo.awayName != null && eventInfo.homeName != null)
                    gameOfferings.Add(ParseGameOffering(eventInfo, betOffers, spreadLabel, moneyLineLabel, totalLabel));
            }

            return gameOfferings;
        }

        private GameOffering ParseGameOffering(dynamic eventInfo, dynamic betOffers, string spreadLabel, string moneyLineLabel, string totalLabel)
        {
            var gameOffering = new GameOffering
            {
                Site = site,
                Sport = eventInfo.group,
                AwayTeam = LocationMapper.GetFullTeamName(eventInfo.awayName.Value, eventInfo.group.Value),
                HomeTeam = LocationMapper.GetFullTeamName(eventInfo.homeName.Value, eventInfo.group.Value),
                DateTime = eventInfo.start.Value
            };

            var pointSpreadJson = ((IEnumerable)betOffers).Cast<dynamic>().FirstOrDefault(g => g.criterion.label == spreadLabel);
            var totalPointsJson = ((IEnumerable)betOffers).Cast<dynamic>().FirstOrDefault(g => g.criterion.label == totalLabel);
            var moneylineJson = ((IEnumerable)betOffers).Cast<dynamic>().FirstOrDefault(g => g.criterion.label == moneyLineLabel);

            if (pointSpreadJson != null)
            {
                var homeSelection = ((IEnumerable)pointSpreadJson.outcomes).Cast<dynamic>().FirstOrDefault(g => LocationMapper.GetFullTeamName(g.participant.Value, gameOffering.Sport) == gameOffering.HomeTeam);
                var awaySelection = ((IEnumerable)pointSpreadJson.outcomes).Cast<dynamic>().FirstOrDefault(g => LocationMapper.GetFullTeamName(g.participant.Value, gameOffering.Sport) == gameOffering.AwayTeam);
                gameOffering.CurrentSpread = pointSpreadJson.outcomes[0].line.Value / 1000.0;
                gameOffering.HomeSpreadPayout = Convert.ToInt32(homeSelection.oddsAmerican.Value);
                gameOffering.AwaySpreadPayout = Convert.ToInt32(awaySelection.oddsAmerican.Value);
            }

            if (moneylineJson != null)
            {
                var homeSelection = ((IEnumerable)moneylineJson.outcomes).Cast<dynamic>().FirstOrDefault(g => LocationMapper.GetFullTeamName(g.participant.Value, gameOffering.Sport) == gameOffering.HomeTeam);
                var awaySelection = ((IEnumerable)moneylineJson.outcomes).Cast<dynamic>().FirstOrDefault(g => LocationMapper.GetFullTeamName(g.participant.Value, gameOffering.Sport) == gameOffering.AwayTeam);
                gameOffering.HomeMoneyLinePayout = Convert.ToInt32(homeSelection.oddsAmerican.Value);
                gameOffering.AwayMoneyLinePayout = Convert.ToInt32(awaySelection.oddsAmerican.Value);
            }

            if (totalPointsJson != null)
            {
                var overSelection = ((IEnumerable)totalPointsJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.label == "Over");
                var underSelection = ((IEnumerable)totalPointsJson.outcomes).Cast<dynamic>().FirstOrDefault(g => g.label == "Under");
                gameOffering.CurrentOverUnder = totalPointsJson.outcomes[0].line.Value / 1000.0;
                gameOffering.OverPayOut = Convert.ToInt32(overSelection.oddsAmerican.Value);
                gameOffering.UnderPayout = Convert.ToInt32(underSelection.oddsAmerican.Value);
            }

            return gameOffering;
        }

        public IEnumerable<PlayerPropOffering> AggregatePlayerProps()
        {
            var nflPlayerProps = GetPlayerProps(NflRequestUrl, PlayerPropConstants.KambiProps["NFL"]);
            var nbaPlayerProps = GetPlayerProps(NbaRequestUrl, PlayerPropConstants.KambiProps["NBA"]);

            return nflPlayerProps.Concat(nbaPlayerProps);
        }

        private IEnumerable<PlayerPropOffering> GetPlayerProps(string sportRequestUrl, List<PlayerPropDescriptions> props)
        {
            var requestString =
                JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(sportRequestUrl).Result).ToString().Replace("event", "Event");

            var games = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(requestString).Events).Cast<dynamic>();
            var playerProps = new List<PlayerPropOffering>();
            foreach (var game in games)
            {
                var eventInfo = game.Event;
                var eventId = game.Event.id;

                var url = BaseUrl + $"/betoffer/event/{eventId}.json?lang=en_US&market=US&includeParticipants=true";
                var playerPropResponse = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(url).Result).ToString();
                var betOfferList = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(playerPropResponse).betOffers).Cast<dynamic>();

                if (eventInfo.awayName != null && eventInfo.homeName != null)
                    foreach (PlayerPropDescriptions prop in props)
                        playerProps.AddRange(ParsePlayerProps(betOfferList, eventInfo, prop));
            }
            return playerProps;
        }

        private IEnumerable<PlayerPropOffering> ParsePlayerProps(IEnumerable<dynamic> betOfferList, dynamic eventInfo, PlayerPropDescriptions prop)
        {
            var propList = betOfferList.Where(b => b.criterion.label == prop.SiteDescription);
            if (propList.Count() == 0)
                return Enumerable.Empty<PlayerPropOffering>();


            var isOverUnderBet = propList.First().betOfferType?.name == "Head to Head";

            return isOverUnderBet ? ParseOverUnder(propList, eventInfo, prop) : ParseMultiOptionsProp(propList, eventInfo, prop);
        }

        private IEnumerable<PlayerPropOffering> ParseOverUnder(IEnumerable<dynamic> propList, dynamic eventInfo, PlayerPropDescriptions prop)
        {
            var playerProps = new List<PlayerPropOffering>();

            var homeTeam = LocationMapper.GetFullTeamName(eventInfo.homeName.Value, eventInfo.group.Value);
            var awayTeam = LocationMapper.GetFullTeamName(eventInfo.awayName.Value, eventInfo.group.Value);

            foreach (dynamic propJson in propList)
            {
                var overAndUnderOutcomeList = ((IEnumerable)propJson.outcomes).Cast<dynamic>(); ;
                var overOutcome = overAndUnderOutcomeList.Single(o => o.label.ToString().Contains(PlayerPropConstants.Over));
                var underOutcome = overAndUnderOutcomeList.Single(o => o.label.ToString().Contains(PlayerPropConstants.Under));

                var overPlayerProp = new PlayerPropOffering
                {
                    Site = site,
                    Sport = eventInfo.group,
                    AwayTeam = awayTeam,
                    HomeTeam = homeTeam,
                    DateTime = eventInfo.start.Value,
                    Payout = Convert.ToInt32(overOutcome.oddsAmerican.Value),
                    PropValue = Convert.ToDouble(overOutcome.label.ToString().Split(' ')[1]),
                    Description = prop.OurDescription,
                    OutcomeDescription = PlayerPropConstants.Over,
                    PlayerName = GetPlayerName(overOutcome.participant.ToString())
                };

                var underPlayerProp = new PlayerPropOffering
                {
                    Site = site,
                    Sport = eventInfo.group,
                    AwayTeam = awayTeam,
                    HomeTeam = homeTeam,
                    DateTime = eventInfo.start.Value,
                    Payout = Convert.ToInt32(underOutcome.oddsAmerican.Value),
                    PropValue = Convert.ToDouble(underOutcome.label.ToString().Split(' ')[1]),
                    Description = prop.OurDescription,
                    OutcomeDescription = PlayerPropConstants.Under,
                    PlayerName = GetPlayerName(overOutcome.participant.ToString())//Not a mistake. Only over has this info. 
                };

                playerProps.Add(overPlayerProp);
                playerProps.Add(underPlayerProp);
            }

            return playerProps;
        }

        private IEnumerable<PlayerPropOffering> ParseMultiOptionsProp(IEnumerable<dynamic> propList, dynamic eventInfo, PlayerPropDescriptions prop)
        { 
            var outcomeList = ((IEnumerable)propList.First().outcomes).Cast<dynamic>();

            if (outcomeList.Any(t => t.criterion != null))
                outcomeList = outcomeList.Where(t => t.criterion.name == prop.SiteOutcomeDescription);

            var playerProps = new List<PlayerPropOffering>();
            foreach (dynamic propOutcome in outcomeList)
            {
                var homeTeam = LocationMapper.GetFullTeamName(eventInfo.homeName.Value, eventInfo.group.Value);
                var awayTeam = LocationMapper.GetFullTeamName(eventInfo.awayName.Value, eventInfo.group.Value);
                var playerProp = new PlayerPropOffering
                {
                    Site = site,
                    Sport = eventInfo.group,
                    AwayTeam = awayTeam,
                    HomeTeam = homeTeam,
                    DateTime = eventInfo.start.Value,
                    Payout = Convert.ToInt32(propOutcome.oddsAmerican.Value),
                    PropValue = null,
                    Description = prop.OurDescription,
                    OutcomeDescription = prop.OurOutcomeDescription,
                    PlayerName = GetPlayerName(propOutcome.participant.ToString())
                };

                playerProps.Add(playerProp);
            }
            return playerProps;
        }

        private string GetPlayerName(string name)
        {
            var playerNameAsArray = RemoveBetween(name, '(', ')').Split(", ");
            return name.ToLower().StartsWith("any other") ?
                 name : playerNameAsArray[playerNameAsArray.Length - 1] + " " + playerNameAsArray[playerNameAsArray.Length - 2];
        }

        private string RemoveBetween(string s, char begin, char end)
        {
            Regex regex = new Regex(string.Format("\\{0}.*?\\{1}", begin, end));
            return regex.Replace(s, string.Empty);
        }
    }
}

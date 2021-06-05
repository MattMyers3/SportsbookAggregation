using Newtonsoft.Json;
using SportsbookAggregation.Data.Models;
using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SportsbookAggregation.SportsBooks
{
    public class BarstoolSportsBook : ISportsBook
    {
        public string GetSportsBookName()
        {
            return "Barstool";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "pivuspa", "barstool");
            return oddsProvider.AggregateFutureOfferings();
        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            var oddsBoostId = GetOddsBoostId();
            var oddsBoostUrl = $"https://eu-offering.kambicdn.org/offering/v2018/pivuspa/betoffer/group/{oddsBoostId}.json?range_start=0&range_size=20&includeParticipants=true&lang=en_US&market=US";
            var betInfoString = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(oddsBoostUrl).Result).ToString();
            var betOfferList = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(betInfoString).betOffers).Cast<dynamic>();

            var oddsBoostOfferings = new List<OddsBoostOffering>();
            foreach (var betOffer in betOfferList)
            {
                oddsBoostOfferings.Add(GetOddsBoost(betOffer));
            }

            return oddsBoostOfferings;
        }

        public OddsBoostOffering GetOddsBoost(dynamic betOffer)
        {
            string description = betOffer.criterion.englishLabel.ToString();
            var split = description.Split(new[] { " (Was", " (was", " (WAS" }, StringSplitOptions.None);
            var prevOdds = 0;
            if( split.Length > 1 && split[1] != null)
            {
                var prevOddsString = Regex.Replace(split[1].Trim(')'), @"\s+", "");//regex removes all spaces from string. Hit a situation where it was  (+ 125)
                if (prevOddsString.Contains('('))
                {
                    var indexParen = prevOddsString.IndexOf("(") - 1;
                    prevOddsString = prevOddsString.Substring(0, indexParen);
                }
                prevOdds = Convert.ToInt32(prevOddsString);
            }
                
            description = split[0];
            return new OddsBoostOffering()
            {
                Description = description,
                PreviousOdds = prevOdds,
                BoostedOdds = ((IEnumerable)betOffer.outcomes).Cast<dynamic>().FirstOrDefault(g => g.status == "OPEN").oddsAmerican,
                Site = GetSportsBookName(),
                Date = betOffer.closed,
            };
        }

        public int GetOddsBoostId()
        {
            var urlToGetOddsBoostId = "https://eu-offering.kambicdn.org/offering/v2018/pivuspa/group.json?depth=4&lang=en_US&market=US";
            var requestString = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(urlToGetOddsBoostId).Result);
            var listOfGroups = (IEnumerable)requestString.group.groups;
            foreach (dynamic group in listOfGroups)
            {
                var embeddedGroups = group.groups;
                foreach (var embedddedGroup in embeddedGroups)
                {
                    if (embedddedGroup.name == "Odds Boosts")
                    {
                       return Convert.ToInt32(embedddedGroup.id);
                    }
                }
            }
            throw new Exception("Can't find Odds Boost ID");
        }

        public IEnumerable<PlayerPropOffering> AggregatePlayerProps()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "pivuspa", "barstool");
            return oddsProvider.AggregatePlayerProps();
        }
    }
}

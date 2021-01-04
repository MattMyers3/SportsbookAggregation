using Newtonsoft.Json;
using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SportsbookAggregation.SportsBooks
{
    public class DraftKingsSportsBook : ISportsBook
    {
        public string GetSportsBookName()
        {
            return "DraftKings";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "dkuspa", "draftkings");
            return oddsProvider.AggregateFutureOfferings();
        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            var eventIdJson = "https://sportsbook.draftkings.com//sites/US-SB/api/v1/displaygroup/815?includePromotions=true&format=json";
            var oddsBoostOfferings = new List<OddsBoostOffering>();
            string requestString = string.Empty;
            try
            {
                requestString = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(eventIdJson).Result).ToString();
            }
            catch(Exception ex)
            {
                return Enumerable.Empty<OddsBoostOffering>(); //No Odds Boosts are available
            }
            
            var eventList = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(requestString).displayGroup.eventGroupDescriptors).Cast<dynamic>();
            foreach (var eventObject in eventList)
            {
                var eventId = eventObject.id;
                var url = $"https://sportsbook.draftkings.com//sites/US-SB/api/v1/eventgroup/{eventId}/full?includePromotions=true&format=json";

                var betOfferResponse = JsonConvert.DeserializeObject<dynamic>(Program.HttpClient.GetStringAsync(url).Result).ToString();
                var betOfferList = ((IEnumerable)JsonConvert.DeserializeObject<dynamic>(betOfferResponse).eventGroup.offerCategories[0].offerSubcategoryDescriptors[0].offerSubcategory.offers).Cast<dynamic>();
                foreach (var betOffer in betOfferList)
                {
                    var innerBetOffer = betOffer[0];
                    var oddsBoost = new OddsBoostOffering();
                    oddsBoost.Description = innerBetOffer.label;
                    oddsBoost.BoostedOdds = innerBetOffer.outcomes[0].oddsAmerican;
                    if(innerBetOffer.outcomes[0].unboostedOutcome != null)
                        oddsBoost.PreviousOdds = innerBetOffer.outcomes[0].unboostedOutcome.oddsAmerican;
                    oddsBoost.Site = GetSportsBookName();
                    oddsBoostOfferings.Add(oddsBoost);
                }
            }
            return oddsBoostOfferings;
        }

        public IEnumerable<PlayerPropOffering> AggregatePlayerProps()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "dkuspa", "draftkings");
            return oddsProvider.AggregatePlayerProps();
        }
    }
}

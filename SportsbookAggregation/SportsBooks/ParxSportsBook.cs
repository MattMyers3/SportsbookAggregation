using SportsbookAggregation.Data.Models;
using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System.Collections.Generic;

namespace SportsbookAggregation.SportsBooks
{
    public class ParxSportsBook : ISportsBook
    {
        public string GetSportsBookName()
        {
            return "Parx";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "parxuspa", "parx");
            return oddsProvider.AggregateFutureOfferings();
        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "parxuspa", "parx_specials");
            return oddsProvider.AggregateOddsBoost();
        }

        public IEnumerable<PlayerPropOffering> AggregatePlayerProps()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "parxuspa", "parx");
            return oddsProvider.AggregatePlayerProps();
        }
    }
}

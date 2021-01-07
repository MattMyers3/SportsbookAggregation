using SportsbookAggregation.Data.Models;
using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System.Collections.Generic;

namespace SportsbookAggregation.SportsBooks
{
    public class UnibetSportsBook : ISportsBook
    {
        public string GetSportsBookName()
        {
            return "Unibet";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "ubuspa", "unibet");
            return oddsProvider.AggregateFutureOfferings();
        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "ubuspa", "unibet_featured");
            return oddsProvider.AggregateOddsBoost();
        }

        public IEnumerable<PlayerPropOffering> AggregatePlayerProps()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "ubuspa", "unibet");
            return oddsProvider.AggregatePlayerProps();
        }
    }
}

using SportsbookAggregation.Data.Models;
using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System.Collections.Generic;

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
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "dkuspa", "draftkings_specials");
            return oddsProvider.AggregateOddsBoost();
        }
    }
}

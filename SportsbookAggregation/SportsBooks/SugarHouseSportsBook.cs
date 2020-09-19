using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System.Collections.Generic;

namespace SportsbookAggregation.SportsBooks
{
    class SugarHouseSportsBook : ISportsBook
    {
        public string GetSportsBookName()
        {
            return "SugarHouse";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "rsiuspa");
            return oddsProvider.AggregateFutureOfferings();
        }
    }
}

using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System.Collections.Generic;

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
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "pivuspa");
            return oddsProvider.AggregateFutureOfferings();
        }
    }
}

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
            throw new System.Exception();
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "dkuspa");
            return oddsProvider.AggregateFutureOfferings();
        }
    }
}

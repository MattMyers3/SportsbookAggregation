using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System.Collections.Generic;

namespace SportsbookAggregation.SportsBooks
{
    public class BetRiversSportsBook : ISportsBook
    {
        public string GetSportsBookName()
        {
            return "BetRivers";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "rsi2uspa");
            return oddsProvider.AggregateFutureOfferings();
        }
    }
}

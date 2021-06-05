using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System.Collections.Generic;

namespace SportsbookAggregation.SportsBooks
{
    public class BetAmericaSportsBook : ISportsBook
    {
        public string GetSportsBookName()
        {
            return "BetAmerica";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "winuspa", "twinspires_super_odds");
            return oddsProvider.AggregateFutureOfferings();
        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "winuspa", "twinspires_super_odds");
            return oddsProvider.AggregateOddsBoost();
        }

        public IEnumerable<PlayerPropOffering> AggregatePlayerProps()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "winuspa", "twinspires_super_odds");
            return oddsProvider.AggregatePlayerProps();
        }
    }
}

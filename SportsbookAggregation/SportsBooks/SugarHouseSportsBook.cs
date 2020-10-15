using SportsbookAggregation.Data.Models;
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
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "rsiuspa", "sugarhouse");
            return oddsProvider.AggregateFutureOfferings();
        }

        public IEnumerable<OddsBoostOffering> AggregateOddsBoost()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "rsiuspa", "sugar_house_specials/rush_street_specials");
            return oddsProvider.AggregateOddsBoost();
        }
    }
}

using System.Collections.Generic;
using SportsbookAggregation.Data.Models;
using SportsbookAggregation.SportsBooks.Models;

namespace SportsbookAggregation.SportsBooks
{
    public interface ISportsBook
    {
        IEnumerable<GameOffering> AggregateFutureOfferings();
        string GetSportsBookName();
    }
}
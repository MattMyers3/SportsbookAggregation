﻿using System.Collections.Generic;
using SportsbookAggregation.SportsBooks.Models;

namespace SportsbookAggregation.SportsBooks
{
    public interface ISportsBook
    {
        IEnumerable<GameOffering> AggregateFutureOfferings();
        IEnumerable<OddsBoostOffering> AggregateOddsBoost();
        string GetSportsBookName();
    }
}
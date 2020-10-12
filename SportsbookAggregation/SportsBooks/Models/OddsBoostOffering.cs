using System;

namespace SportsbookAggregation.SportsBooks.Models
{
    public class OddsBoostOffering
    {
        public string Description { get; set; }
        public int PreviousOdds { get; set; }
        public int BoostedOdds { get; set; }

        public string Sport { get; set; }

        public string Site { get; set; }
        public DateTime Date { get; set; }
    }
}
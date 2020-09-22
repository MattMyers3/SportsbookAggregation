using System;

namespace SportsbookAggregation.Alerts.Models
{
    public class Alert
    {
        public Guid AlertId { get; set; }
        public Guid GameId { get; set; }

        public string Type { get; set; }
        public double? CurrentOver { get; set; }

        public double? CurrentUnder { get; set; }

        public int? CurrentOverPayout { get; set; }
        public int? CurrentUnderPayout { get; set; }

        public double? CurrentHomeSpread { get; set; }
        public int? CurrentHomeSpreadPayout { get; set; }

        public double? CurrentAwaySpread { get; set; }
        public int? CurrentAwaySpreadPayout { get; set; }

        public int? CurrentHomeMoneyLine { get; set; }

        public int? CurrentAwayMoneyLine { get; set; }

    }
}


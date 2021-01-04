using System;

namespace SportsbookAggregation.SportsBooks.Models
{
    public class PlayerPropOffering
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime DateTime { get; set; }
        public string Site { get; set; }
        public int? Payout { get; set; }
        public double? PropValue { get; set; }
        public string Description { get; set; }
        public string Sport { get; set; }
        public bool OnHomeTeam { get; set; }
    }
}

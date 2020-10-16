using System;

namespace SportsbookAggregation.Data.Models
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid PlayerId { get; set; }
    }
}

using System.Collections.Generic;

namespace SportsbookAggregation.Constants
{
    public static class PlayerPropConstants
    {
        public const string TouchdownScorer = "Touchdown Scorer";
        public const string BasketScorer = "Basket Scorer";
        public const string PassingYards = "Passing Yards";
        public const string RushingYards = "Rushing Yards";
        public const string ReceivingYards = "Receiving Yards";
        public const string TotalReceptions = "Total Receptions";
        public const string TotalTDsThrown = "Total TD's Thrown";




        public const string Over = "Over";
        public const string Under = "Under";
        public const string First = "First";
        public const string Last = "Last";
        public const string Anytime = "Anytime";

        public static Dictionary<string, List<PlayerPropDescriptions>> KambiProps = new Dictionary<string, List<PlayerPropDescriptions>>()
        {
            {  "NFL", new List<PlayerPropDescriptions>()
                {
                    new PlayerPropDescriptions("Touchdown Scorer", "First", TouchdownScorer, First),
                    new PlayerPropDescriptions("Touchdown Scorer", "To Score", TouchdownScorer, Anytime),
                    new PlayerPropDescriptions("Touchdown Scorer", "Last", TouchdownScorer, Last),
                    new PlayerPropDescriptions("Total Passing Yards by the Player", null, PassingYards, null),
                    new PlayerPropDescriptions("Total Rushing Yards by the Player - Including Overtime", null, RushingYards, null),
                    new PlayerPropDescriptions("Total Receiving Yards by the Player - Including Overtime", null, ReceivingYards, null),
                    new PlayerPropDescriptions("Total Receptions by the Player", null, ReceivingYards, null),
                    new PlayerPropDescriptions("Total Receiving Yards by the Player - Including Overtime", null, ReceivingYards, null),
                    new PlayerPropDescriptions("Total Receiving Yards by the Player - Including Overtime", null, ReceivingYards, null),
                    new PlayerPropDescriptions("Total Touchdown Passes Thrown by the Player - Including Overtime", null, TotalTDsThrown, null),
                }
            },
            {  "NBA", new List<PlayerPropDescriptions>()
                {
                    new PlayerPropDescriptions("Player to Score the First Field Goal of the Game", null, BasketScorer, First),
                }
            }
        };

        public const string FanduelFirstTouchdown = "First Touchdown Scorer";
        public const string FanduelFirstBasket = "First Basket";

        public const string FoxBetFirstTouchdown = "1st Touchdown Scorer (Incl. OT)";
        public const string FoxBetFirstBasket = "Nothing";
    }

    public class PlayerPropDescriptions
    {
        public string SiteDescription { get; }
        public string SiteOutcomeDescription { get; }
        public string OurDescription { get; }
        public string OurOutcomeDescription { get; }


        public PlayerPropDescriptions(string siteDescription, string siteOutComeDescription, string ourDescription, string ourOutcomeDescription)
        {
            SiteDescription = siteDescription;
            SiteOutcomeDescription = siteOutComeDescription;
            OurDescription = ourDescription;
            OurOutcomeDescription = ourOutcomeDescription;
        }
    }
}

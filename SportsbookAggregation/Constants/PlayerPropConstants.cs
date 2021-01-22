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
        public const string Receptions = "Receptions";
        public const string TotalReceptions = "Total Receptions";
        public const string TotalTDsThrown = "Total TD's Thrown";
        public const string TotalPoints = "Total Points";
        public const string TotalAssists = "Total Assists";
        public const string TotalRebounds = "Total Rebounds";
        public const string TotalThreePointers = "Total Three Pointers";

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
                    new PlayerPropDescriptions("Total Receptions by the Player", null, Receptions, null),
                    new PlayerPropDescriptions("Total Touchdown Passes Thrown by the Player - Including Overtime", null, TotalTDsThrown, null)
                }
            },
            {  "NBA", new List<PlayerPropDescriptions>()
                {
                    new PlayerPropDescriptions("Player to Score the First Field Goal of the Game", null, BasketScorer, First),
                    new PlayerPropDescriptions("Points scored by the player", null, TotalPoints, null),
                    new PlayerPropDescriptions("Assists by the player", null, TotalAssists, null),
                    new PlayerPropDescriptions("Rebounds by the player", null, TotalRebounds, null),
                    new PlayerPropDescriptions("3-point field goals made by the player", null, TotalThreePointers, null)
                }
            }
        };

        public static Dictionary<string, List<PlayerPropDescriptions>> FoxBetProps = new Dictionary<string, List<PlayerPropDescriptions>>()
        {
            { "NFL", new List<PlayerPropDescriptions>()
                {
                    new PlayerPropDescriptions("1st Touchdown Scorer (Incl. OT)", null, TouchdownScorer, First),
                    new PlayerPropDescriptions("Anytime Touchdown (Incl. OT)", null, TouchdownScorer, Anytime),
                    new PlayerPropDescriptions("Last Touchdown Scorer (Incl. OT)", null, TouchdownScorer, Last),
                    new PlayerPropDescriptions("Player Passing Yards (Incl. OT)", null, PassingYards, null),
                    new PlayerPropDescriptions("Player Rushing Yards (Incl. OT)", null, RushingYards, null),
                    new PlayerPropDescriptions("Player Receiving Yards (Incl. OT)", null, ReceivingYards, null),
                    new PlayerPropDescriptions("Player Receptions (Incl. OT)", null, Receptions, null),
                    new PlayerPropDescriptions("Player Passing Touchdowns (Incl. OT)", null, TotalTDsThrown, null)
                }
            },
            { "NBA", new List<PlayerPropDescriptions>()
                {
                    new PlayerPropDescriptions("BASKETBALL:FTOU:PLRPTS", null, TotalPoints, null),
                    new PlayerPropDescriptions("BASKETBALL:FTOU:PLRASS", null, TotalAssists, null),
                    new PlayerPropDescriptions("BASKETBALL:FTOU:PLRREB", null, TotalRebounds, null),
                    new PlayerPropDescriptions("BASKETBALL:FTOU:PLR3PT", null, TotalThreePointers, null)
                }
            }
        };

        public static Dictionary<string, List<PlayerPropDescriptions>> FanDuelProps = new Dictionary<string, List<PlayerPropDescriptions>>()
        {
            { "NFL", new List<PlayerPropDescriptions>()
                {
                    new PlayerPropDescriptions("First Touchdown Scorer - Any (E-Venue)", null, TouchdownScorer, First),
                    new PlayerPropDescriptions("Any Time Touchdown Scorer - Any (E-Venue)", null, TouchdownScorer, Anytime),
                    new PlayerPropDescriptions("Last Touchdown Scorer - Any (E-Venue)", null, TouchdownScorer, Last),
                    new PlayerPropDescriptions("Player X Total Passing Yards O/U (E-Venue)", null, PassingYards, null),
                    new PlayerPropDescriptions("Player X Total Rushing Yards O/U (E-Venue)", null, RushingYards, null),
                    new PlayerPropDescriptions("Player X Total Receiving Yards O/U (E-Venue)", null, ReceivingYards, null),
                    new PlayerPropDescriptions("Player X Total Receptions O/U (E-Venue)", null, Receptions, null),
                    new PlayerPropDescriptions("Player X Total Passing Touchdowns O/U (E-Venue)", null, TotalTDsThrown, null)
                }
            },
            { "NBA", new List<PlayerPropDescriptions>()
                {
                    new PlayerPropDescriptions("First Basket - Any (E-Venue)", null, BasketScorer, First),
                    new PlayerPropDescriptions("Player X Total Points O/U (E-Venue)", null, TotalPoints, null),
                    new PlayerPropDescriptions("Player X Total Assists O/U (E-Venue)", null, TotalAssists, null),
                    new PlayerPropDescriptions("Player X Total Rebounds O/U (E-Venue)", null, TotalRebounds, null),
                    new PlayerPropDescriptions("Player X Total 3 Point Field Goals O/U (E-Venue)", null, TotalThreePointers, null),
                }
            }
        };
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

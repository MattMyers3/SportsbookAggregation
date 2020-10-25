using System;
using System.Collections.Generic;
using System.Text;

namespace SportsbookAggregation.SportsBooks
{
    public class LocationMapper
    {

        public static string GetFullTeamName(string shortTeamName, string sport)
        {
            if (sport == "NCAAF")
                return MapCollege(shortTeamName);

            var teamNameArray = shortTeamName.Split(' ');
            var location = LocationMapper.MapLocation(teamNameArray[0], sport);
            return $"{location}{shortTeamName.Substring(teamNameArray[0].Length)}";
        }
        
        private static string MapCollege(string college)
        {
            college = college.Replace('-', '-');
            if (college.StartsWith('#'))//#1 Villanova, need to strip the rank
                college = college.Substring(college.IndexOf(' ') + 1);
            switch(college.ToLower())
            {
                case "abilene christian university":
                    return "Abilene Christian";
                case "brigham young cougars":
                    return "BYU";
                case "central florida knights":
                case "central florida":
                    return "UCF";
                case "florida intl":
                case "florida international":  
                    return "FIU";
                case "hawaii warriors":
                    return "Hawaii";
                case "la lafayette":
                case "louisiana-lafayette":
                case "louisiana lafayette ragin cajuns":
                case "ul lafayette":
                    return "Louisiana";
                case "louisiana monroe warhawks":
                case "ul monroe":
                    return "Louisiana-Monroe";
                case "miami florida":
                case "miami florida hurricanes":
                    return "Miami (FL)";
                case "middle tennessee state":
                case "middle tenn state blue raiders":
                    return "Middle Tennessee";
                case "mississippi rebels":
                case "mississippi":
                    return "Ole Miss";
                case "north carolina st wolfpack":
                case "north carolina state":
                    return "NC State";
                case "se missouri state":
                    return "Southeast Missouri State";
                case "southern methodist mustangs":
                    return "SMU";
                case "southern mississippi":
                case "southern mississippi golden eagles":
                    return "Southern Miss";
                case "ut san antonio":
                case "texas san antonio roadrunners":
                    return "UTSA";
                default:
                    return college;
            }
        }
        private static string MapLocation(string abbreviation, string sport)
        {
            switch (abbreviation.ToUpper())
            {
                case "ARI":
                    return "Arizona";
                case "ATL":
                    return "Atlanta";
                case "BAL":
                    return "Baltimore";
                case "BOS":
                    return "Boston";
                case "BKN":
                    return "Brooklyn";
                case "BUF":
                    return "Buffalo";
                case "CAR":
                    return "Carolina";
                case "CHA":
                    return "Charlotte";
                case "CHI":
                    return "Chicago";
                case "CIN":
                    return "Cincinnati";
                case "CLE":
                    return "Cleveland";
                case "DAL":
                    return "Dallas";
                case "DEN":
                    return "Denver";
                case "DET":
                    return "Detroit";
                case "GB":
                    return "Green Bay";
                case "GS":
                    return "Golden State";
                case "HOU":
                    return "Houston";
                case "IND":
                    return sport == "NBA" ? "Indiana" : "Indianapolis";
                case "JAX":
                    return "Jacksonville";
                case "KC":
                    return "Kansas City";
                case "LA":
                    return "Los Angeles";
                case "LV":
                    return "Las Vegas";
                case "MEM":
                    return "Memphis";
                case "MIA":
                    return "Miami";
                case "MIL":
                    return "Milwaukee";
                case "MIN":
                    return "Minnesota";
                case "NE":
                    return "New England";
                case "NO":
                    return "New Orleans";
                case "NY":
                    return "New York";
                case "OKC":
                    return "Oklahoma City";
                case "ORL":
                    return "Orlando";
                case "PHI":
                    return "Philadelphia";
                case "PIT":
                    return "Pittsburgh";
                case "PHX":
                    return "Phoenix";
                case "POR":
                    return "Portland";
                case "SAC":
                    return "Sacramento";
                case "SA":
                    return "San Antonio";
                case "SEA":
                    return "Seattle";
                case "SF":
                    return "San Francisco";
                case "TB":
                    return "Tampa Bay";
                case "TEN":
                    return "Tennessee";
                case "TOR":
                    return "Toronto";
                case "UTA":
                    return "Utah";
                case "WAS":
                    return "Washington";
                case "SD":
                    return "San Diego";
                case "OAK":
                    return "Oakland";
                case "TEX":
                    return "Texas";
                case "STL":
                    return "St. Louis";
                case "COL":
                    return "Colorado";
                default:
                    return abbreviation;

            }
        }
    }
}

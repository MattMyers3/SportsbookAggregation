﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SportsbookAggregation.SportsBooks
{
    public class LocationMapper
    {

        public static string GetFullTeamName(string shortTeamName, string sport)
        {
            if (sport == "NCAAF" || sport == "NCAAB")
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
            switch (college.ToLower())
            {
                case "abilene christian university":
                    return "Abilene Christian";
                case "albany ny great danes":
                    return "Albany";
                case "arkansas pine bluff":
                    return "Arkansas-Pine Bluff";
                case "austin peay state":
                    return "Austin Peay";
                case "brigham young cougars":
                case "brigham young":
                    return "BYU";
                case "buffalo u":
                    return "Buffalo";
                case "cal poly slo":
                    return "Cal Poly";
                case "central conn. state":
                    return "Central Connecticut";
                case "csu bakersfield":
                case "california state bakersfield roadrunners":
                case "cs bakersfield":
                    return "Cal State Bakersfield";
                case "csu fullerton":
                case "csu fullerton titans":
                    return "Cal State Fullerton";
                case "csu northridge":
                case "cs northridge":
                    return "Cal State Northridge";
                case "central florida knights":
                case "central florida":
                    return "UCF";
                case "college of charleston":
                    return "Charleston";
                case "cincinnati u":
                    return "Cincinnati";
                case "delaware blue hens":
                    return "Delaware";
                case "depaul":
                    return "DePaul";
                case "detroit":
                    return "Detroit Mercy";
                case "east tenn state":
                    return "East Tennessee State";
                case "florida intl":
                case "florida international":
                case "florida international panthers":
                case "florida intl panthers":
                    return "FIU";
                case "gardner webb":
                    return "Gardner-Webb";
                case "gonzaga bulldogs":
                    return "Gonzaga";
                case "grambling st":
                case "grambling":
                    return "Grambling State";
                case "uw green bay":
                case "wisconsin green bay phoenix":
                case "wisc green bay":
                    return "Green Bay";
                case "hawaii warriors":
                    return "Hawaii";
                case "houston u":
                    return "Houston";
                case "indiana u.":
                    return "Indiana";
                case "arkansas little rock":
                    return "Little Rock";
                case "liu":
                    return "LIU[d]";
                case "long beach state 49ers":
                    return "Long Beach State";
                case "la lafayette":
                case "la-lafayette":
                case "louisiana-lafayette":
                case "louisiana lafayette ragin cajuns":
                case "ul lafayette ragin cajuns":
                case "ul lafayette":
                case "louisiana lafayette":
                    return "Louisiana";
                case "louisiana monroe warhawks":
                case "ul monroe":
                case "ul - monroe":
                case "louisiana monroe":
                case "louisiana - monroe":
                    return "Louisiana-Monroe";
                case "miami florida":
                case "miami florida hurricanes":
                    return "Miami (FL)";
                case "miami ohio":
                case "miami-ohio redhawks":
                    return "Miami (OH)";
                case "miami ohio red hawks":
                    return "Miami (OH)";
                case "middle tennessee state":
                case "middle tenn state blue raiders":
                    return "Middle Tennessee";
                case "uw milwaukee":
                case "wisconsin milwaukee":
                case "wisc milwaukee":
                case "wisconsin milwaukee panthers":
                    return "Milwaukee";
                case "miss valley state":
                    return "Mississippi Valley State";
                case "mississippi rebels":
                case "mississippi":
                    return "Ole Miss";
                case "new jersey tech highlanders":
                    return "NJIT";
                case "nicholls state":
                    return "Nicholls";
                case "nicholls state colonels":
                    return "Nicholls";
                case "north alabama":
                    return "UNA";
                case "n carolina central":
                case "nc central":
                    return "North Carolina Central";
                case "north carolina st wolfpack":
                case "north carolina state":
                case "north carolina state wolfpack":
                    return "NC State";
                case "no. colorado":
                    return "Northern Colorado";
                case "northwestern state uni demons":
                case "northwestern st":
                    return "Northwestern State";
                case "ohio st.":
                    return "Ohio State";
                case "nebraska-omaha":
                case "nebraska omaha":
                case "nebraska omaha mavericks":
                    return "Omaha";
                case "ipfw":
                    return "Purdue Fort Wayne";
                case "saint marys":
                case "saint marys ca":
                case "saint mary´s ca":
                case "saint marys gaels":
                    return "Saint Mary's";
                case "san josé state":
                    return "San Jose State";
                case "se louisiana":
                    return "Southeastern Louisiana";
                case "se missouri state":
                case "se missouri state redhawks":
                    return "Southeast Missouri State";
                case "southern university":
                    return "Southern";
                case "southern methodist mustangs":
                case "southern methodist":
                    return "SMU";
                case "southern mississippi":
                case "southern mississippi golden eagles":
                    return "Southern Miss";
                case "stephen f austin":
                    return "Stephen F. Austin";
                case "seattle university":
                case "seattle":
                case "seattle redhawks":
                case "seattle u":
                    return "SU";
                case "st. francis (bkn)":
                case "st francis brooklyn":
                case "st. francis ny":
                case "st. francis (ny)":
                    return "St. Francis Brooklyn";
                case "st. francis (pa)":
                case "st francis (pa)":
                    return "Saint Francis";
                case "usc upstate":
                case "sc upstate spartans":
                    return "South Carolina Upstate";
                case "st bonaventure":
                    return "St. Bonaventure";
                case "st. peter's":
                case "saint peters peacocks":
                    return "Saint Peter's";
                case "st johns":
                case "st johns red storm":
                case "st. johns":
                    return "St. John's";
                case "st. joseph's":
                case "st josephs":
                case "st. josephs":
                    return "Saint Joseph's";
                case "t a&m corpus christi":
                case "texas a&m-corpus christi": //took me forever to figure out that's a different dash
                case "texas a&m-cc":
                    return "Texas A&M–Corpus Christi";
                case "connecticut":
                case "connecticut huskies":
                    return "UConn";
                case "california irvine":
                case "california irvine anteaters":
                case "cal irvine":
                    return "UC Irvine";
                case "california riverside highlanders":
                    return "UC Riverside";
                case "ucsb":
                case "cal santa barbara":
                case "cal santa barbara gauchos":
                    return "UC Santa Barbara";
                case "illinois chicago":
                case "illinois chicago flames":
                    return "UIC";
                case "massachusetts":
                case "massachusetts minutemen":
                    return "UMass";
                case "md baltimore county retrievers":
                    return "UMBC";
                case "missouri kansas city kangaroos":
                    return "UMKC";
                case "north carolina greensboro":
                    return "UNC Greensboro";
                case "uncw":
                case "nc wilmington":
                    return "UNC Wilmington";
                case "southern california trojans":
                    return "USC";
                case "tennessee martin":
                case "tennessee-martin":
                case "tennessee martin skyhawks":
                    return "UT Martin";
                case "utah valley state":
                    return "Utah Valley";
                case "texas el paso miners":
                case "texas el paso":
                    return "UTEP";
                case "ut rio grande valley":
                case "texas rio grande":
                    return "UTRGV";
                case "ut san antonio":
                case "texas san antonio roadrunners":
                    return "UTSA";
                case "virginia commonwealth rams":
                    return "VCU";
                case "virginia military keydets":
                    return "VMI";
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
                case "PHO":
                    return "Phoenix";
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
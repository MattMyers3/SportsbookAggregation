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
            switch(college.ToLower())
            {
                case "abilene christian university":
                    return "Abilene Christian";
                case "arkansas pine bluff":
                    return "Arkansas-Pine Bluff";
                case "austin peay state":
                    return "Austin Peay";
                case "brigham young cougars":
                case "brigham young":
                    return "BYU";
                case "cal poly slo":
                    return "Cal Poly";
                case "central conn. state":
                    return "Central Connecticut";
                case "csu bakersfield":
                    return "Cal State Bakersfield";
                case "csu fullerton":
                case "csu fullerton titans":
                    return "Cal State Fullerton";
                case "csu northridge":
                    return "Cal State Northridge";
                case "central florida knights":
                case "central florida":
                    return "UCF";
                case "college of charleston":
                    return "Charleston";
                case "delaware blue hens":
                    return "Delaware";
                case "florida intl":
                case "florida international":
                case "florida international panthers":
                    return "FIU";
                case "gardner webb":
                    return "Gardner-Webb";
                case "uw green bay":
                    return "Green Bay";
                case "hawaii warriors":
                    return "Hawaii";
                case "long beach state 49ers":
                    return "Long Beach State";
                case "la lafayette":
                case "louisiana-lafayette":
                case "louisiana lafayette ragin cajuns":
                case "ul lafayette":
                case "louisiana lafayette":
                    return "Louisiana";
                case "louisiana monroe warhawks":
                case "ul monroe":
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
                case "mississippi rebels":
                case "mississippi":
                    return "Ole Miss";
                case "north alabama":
                    return "UNA";
                case "n carolina central":
                case "nc central":
                    return "North Carolina Central";
                case "north carolina st wolfpack":
                case "north carolina state":
                    return "NC State";
                case "nebraska-omaha":
                case "nebraska omaha":
                case "nebraska omaha mavericks":
                    return "Omaha";
                case "saint marys":
                case "saint marys ca":
                case "saint marys gaels":
                    return "Saint Mary's";
                case "san josé state":
                    return "San Jose State";
                case "se louisiana":
                    return "Southeastern Louisiana";
                case "se missouri state":
                case "se missouri state redhawks":
                    return "Southeast Missouri State";
                case "southern methodist mustangs":
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
                    return "St. Francis Brooklyn";
                case "st. francis (pa)":
                case "st francis (pa)":
                    return "Saint Francis";
                case "usc upstate":
                    return "South Carolina Upstate";
                case "st bonaventure":
                    return "St. Bonaventure";
                case "st. peter's":
                case "saint peters peacocks":
                    return "Saint Peter's";
                case "utah valley state":
                    return "Utah Valley";
                case "t a&m corpus christi":
                case "texas a&m-corpus christi": //took me forever to figure out that's a different dash
                    return "Texas A&M–Corpus Christi";
                case "california riverside highlanders":
                    return "UC Riverside";
                case "ucsb":
                    return "UC Santa Barbara";
                case "uncw":
                    return "UNC Wilmington";
                case "missouri kansas city kangaroos":
                    return "UMKC";
                case "north carolina greensboro":
                    return "UNC Greensboro";
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
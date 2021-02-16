using SportsbookAggregation.SportsBooks;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsbookAggregation.API.APIModels
{
    public interface IUpdateObject 
    {
        
    }

    public class GameLineUpdateObject : IUpdateObject
    {
        public GameLineUpdateObject(IEnumerable<GameOffering> gamelines, IEnumerable<string> sportsbooks)
        {
            Sportsbooks = sportsbooks;
            GameLines = gamelines;
        }

        public IEnumerable<string> Sportsbooks { get; set; }
        public IEnumerable<GameOffering> GameLines { get; set; }
    }

    public class OddsBoostUpdateObject : IUpdateObject
    {
        public OddsBoostUpdateObject(IEnumerable<OddsBoostOffering> oddsBoosts, IEnumerable<string> sportsbooks)
        {
            Sportsbooks = sportsbooks;
            OddsBoosts = oddsBoosts;
        }
        public IEnumerable<string> Sportsbooks { get; set; }
        public IEnumerable<OddsBoostOffering> OddsBoosts { get; set; }
    }

    public class PlayerPropUpdateObject : IUpdateObject
    {
        public PlayerPropUpdateObject(IEnumerable<PlayerPropOffering> playerProps, IEnumerable<string> sportsbooks)
        {
            Sportsbooks = sportsbooks;
            PlayerProps = playerProps;
        }
        public IEnumerable<string> Sportsbooks { get; set; }
        public IEnumerable<PlayerPropOffering> PlayerProps { get; set; }
    }
}

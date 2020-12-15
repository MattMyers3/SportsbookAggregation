using System;
using System.Collections.Generic;
using System.Linq;
using SportsbookAggregation.Data;
using SportsbookAggregation.Data.Models;
using SportsbookAggregation.SportsBooks;
using SportsbookAggregation.SportsBooks.Mappers;
using SportsbookAggregation.SportsBooks.Models;

namespace SportsbookAggregation
{
    public class SportsbookOfferingsUpdater
    {
        private readonly Context dbContext;

        public SportsbookOfferingsUpdater(Context dbContext)
        {
            this.dbContext = dbContext;
        }


        public void WriteOddsBoosts(IEnumerable<OddsBoostOffering> oddsBoostOfferings)
        {
            foreach(var oddsBoostOffering in oddsBoostOfferings)
            {
                var boostExists = dbContext.OddsBoostRepository.Read().Any(o => o.Description == oddsBoostOffering.Description);
                if (boostExists)
                    UpdateBoost(oddsBoostOffering);
                else
                    CreateBoost(oddsBoostOffering);
            }
        }

        private void UpdateBoost(OddsBoostOffering oddsBoostOffering)
        {
            var oddsBoost = dbContext.OddsBoostRepository.Read().Single(o => o.Description == oddsBoostOffering.Description);
            oddsBoost.IsAvailable = true;
            oddsBoost.LastRefresh = DateTime.UtcNow;
            dbContext.OddsBoostRepository.Update(oddsBoost);
        }

        private void CreateBoost(OddsBoostOffering oddsBoostOffering)
        {
            var siteId = GetSiteId(oddsBoostOffering.Site);
            var sportId = GetSportId(oddsBoostOffering.Sport);
            dbContext.OddsBoostRepository.Create(new OddsBoost
            {
                BoostedOdds = oddsBoostOffering.BoostedOdds,
                Date = oddsBoostOffering.Date,
                Description = oddsBoostOffering.Description,
                GamblingSiteId = siteId,
                PreviousOdds = oddsBoostOffering.PreviousOdds,
                SportId = sportId,
                LastRefresh = DateTime.UtcNow,
                IsAvailable = true
            });
        }

        public void WriteGameOfferings(IEnumerable<GameOffering> gameOfferings)
        {
            foreach (var gameOffering in gameOfferings)
            {
                try
                {
                    if (gameOffering.DateTime < DateTime.UtcNow)
                        continue;

                    var sportGuid = GetSportId(gameOffering.Sport);
                    var homeTeamId = GetTeamIdFromTeamName(gameOffering.HomeTeam, gameOffering.Sport);
                    var awayTeamId = GetTeamIdFromTeamName(gameOffering.AwayTeam, gameOffering.Sport);
                    var siteId = GetSiteId(gameOffering.Site);

                    var gameId = GetGameId(gameOffering.DateTime, homeTeamId, awayTeamId) ??
                                    CreateGame(gameOffering.DateTime, homeTeamId, awayTeamId, sportGuid);

                    var gameLine = GetGameLine(gameId, siteId);
                    if (gameLine == null)
                        CreateGameLine(gameId, siteId, gameOffering);
                    else
                        UpdateGameLine(gameLine, gameOffering);
                }
                catch(TeamNotFoundException e)
                {
                  Console.WriteLine(e.Message);
                    // Program.SendAlerts(e.Message);
                }
            }
        }

        private bool IsCollegeSport(string sport)
        {
            return sport == "NCAAF" || sport == "NCAAB";
        }

        public void SetOfferingsToNotAvailable()
        {
            var allLines = dbContext.GameLineRepository.Read();
            foreach (var gameLine in allLines)
                gameLine.IsAvailable = false;
            
            
            dbContext.GameLineRepository.UpdateRange(allLines);

            var allBoosts = dbContext.OddsBoostRepository.Read();
            foreach (var boost in allBoosts)
                boost.IsAvailable = false;


            dbContext.OddsBoostRepository.UpdateRange(allBoosts);
        }

        private void UpdateGameLine(GameLine gameLine, GameOffering gameOffering)
        {
            if (gameLine.OpeningSpread == null)
                gameLine.OpeningSpread = gameOffering.CurrentSpread;
            if (gameLine.OpeningOverUnder == null)
                gameLine.OpeningOverUnder = gameOffering.CurrentOverUnder;
            gameLine.CurrentSpread = gameOffering.CurrentSpread;
            gameLine.CurrentOverUnder = gameOffering.CurrentOverUnder;
            gameLine.HomeMoneyLinePayout = gameOffering.HomeMoneyLinePayout;
            gameLine.AwayMoneyLinePayout = gameOffering.AwayMoneyLinePayout;
            gameLine.OverPayOut = gameOffering.OverPayOut;
            gameLine.UnderPayout = gameOffering.UnderPayout;
            gameLine.HomeSpreadPayout = gameOffering.HomeSpreadPayout;
            gameLine.AwaySpreadPayout = gameOffering.AwaySpreadPayout;
            gameLine.LastRefresh = DateTime.UtcNow;
            gameLine.IsAvailable = true;
            dbContext.GameLineRepository.Update(gameLine);
        }

        private void CreateGameLine(Guid gameId, Guid siteId, GameOffering gameOffering)
        {
            dbContext.GameLineRepository.Create(new GameLine
            {
                GameId = gameId,
                GamblingSiteId = siteId,
                AwayMoneyLinePayout = gameOffering.AwayMoneyLinePayout,
                AwaySpreadPayout = gameOffering.AwaySpreadPayout,
                CurrentSpread = gameOffering.CurrentSpread,
                CurrentOverUnder = gameOffering.CurrentOverUnder,
                HomeMoneyLinePayout = gameOffering.HomeMoneyLinePayout,
                HomeSpreadPayout = gameOffering.HomeSpreadPayout,
                OpeningOverUnder = gameOffering.CurrentOverUnder,
                OpeningSpread = gameOffering.CurrentSpread,
                OverPayOut = gameOffering.OverPayOut,
                UnderPayout = gameOffering.UnderPayout,
                LastRefresh = DateTime.UtcNow,
                IsAvailable = true
            });
        }

        private GameLine GetGameLine(Guid gameId, Guid siteId)
        {
            return dbContext.GameLineRepository.Read()
                .SingleOrDefault(gl => gl.GameId == gameId && gl.GamblingSiteId == siteId);
        }

        private Guid CreateGame(DateTime gameOfferingDateTime, Guid homeTeamId, Guid awayTeamId, Guid sportId)
        {
            var game = new Game {AwayTeamId = awayTeamId, HomeTeamId = homeTeamId, TimeStamp = gameOfferingDateTime, SportId = sportId};
            dbContext.GameRepository.Create(game);
            return game.GameId;
        }

        private Guid? GetGameId(DateTime gameTime, Guid homeTeamId, Guid awayTeamId)
        {
            var matchingGames = dbContext.GameRepository.Read()
                .Where(g => g.HomeTeamId == homeTeamId && g.AwayTeamId == awayTeamId && g.TimeStamp.Date == gameTime.Date);
            return matchingGames.FirstOrDefault(g => Math.Abs(g.TimeStamp.Hour - gameTime.Hour) <= 1)?.GameId;
        }

        private Guid GetTeamIdFromTeamName(string teamName, string sport)
        {   
            teamName = LocationMapper.GetFullTeamName(teamName, sport);
            if(IsCollegeSport(sport))
                teamName = MascotMapper.GetFullNameUsingCollege(teamName);

            var team = dbContext.TeamRepository.Read().SingleOrDefault((t => (t.Location + " " + t.Mascot == teamName)));
            if (team == null)
                throw new TeamNotFoundException("Need to add a mapping for the following team: " + teamName);

            return team.TeamId;
           
        }

        private Guid GetSiteId(string site)
        {
            return dbContext.GamblingSiteRepository.Read().Single(s => s.Name == site).GamblingSiteId;
        }

        private Guid GetSportId(string name)
        {
            if (name == null) 
                return dbContext.SportRepository.Read().Single(s => s.Name == "Unknown").SportId;

            var sport = dbContext.SportRepository.Read().FirstOrDefault(s => s.Name == name);
            if(sport == null)
                return dbContext.SportRepository.Read().Single(s => s.Name == "Unknown").SportId;

            return sport.SportId;
        }
    }
}
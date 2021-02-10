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

        public void Update(IEnumerable<GameOffering> gameOfferings, IEnumerable<OddsBoostOffering> oddsBoostOfferings, IEnumerable<PlayerPropOffering> playerPropOfferings)
        {
            SetOfferingsToNotAvailable();
            WriteGameOfferings(gameOfferings);
            WriteOddsBoosts(oddsBoostOfferings);
            WritePlayerProps(playerPropOfferings);
            dbContext.SaveChanges();
        }

        public void WriteOddsBoosts(IEnumerable<OddsBoostOffering> oddsBoostOfferings)
        {
            foreach (var oddsBoostOffering in oddsBoostOfferings)
            {
                var boost = dbContext.OddsBoostRepository.Read().SingleOrDefault(o => o.Description == oddsBoostOffering.Description && o.GamblingSite.Name.Equals(oddsBoostOffering.Site, StringComparison.OrdinalIgnoreCase));
                if (boost != null)
                    UpdateBoost(oddsBoostOffering, boost);
                else
                    CreateBoost(oddsBoostOffering);
            }
        }

        private void UpdateBoost(OddsBoostOffering oddsBoostOffering, OddsBoost boost)
        {
            boost.IsAvailable = true;
            boost.LastRefresh = DateTime.UtcNow;
        }

        private void CreateBoost(OddsBoostOffering oddsBoostOffering)
        {
            var siteId = GetSiteId(oddsBoostOffering.Site);
            var sportId = GetSportId(oddsBoostOffering.Sport);
            dbContext.OddsBoostRepository.CreateWithoutSaving(new OddsBoost
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
                catch (TeamNotFoundException e)
                {
                    Program.WriteToConsole(e.Message);
                    Program.SendAlerts(e.Message);
                }
            }
        }

        public void WritePlayerProps(IEnumerable<PlayerPropOffering> playerProps)
        {
            foreach (var playerProp in playerProps)
            {
                var playerPropInDatabase = TryGetPlayerProp(playerProp);
                if (playerPropInDatabase == null)
                    CreatePlayerProp(playerProp);
                else
                    UpdatePlayerProp(playerPropInDatabase, playerProp);
            }
        }

        private void CreatePlayerProp(PlayerPropOffering playerProp)
        {
            var sportGuid = GetSportId(playerProp.Sport);
            var homeTeamId = GetTeamIdFromTeamName(playerProp.HomeTeam, playerProp.Sport);
            var awayTeamId = GetTeamIdFromTeamName(playerProp.AwayTeam, playerProp.Sport);
            var gameId = GetGameId(playerProp.DateTime, homeTeamId, awayTeamId) ??
                            CreateGame(playerProp.DateTime, homeTeamId, awayTeamId, sportGuid);

            var gamblingSiteId = GetSiteId(playerProp.Site);

            dbContext.PlayerPropRepository.CreateWithoutSaving(new PlayerProp
            {
                IsAvailable = true,
                LastRefresh = DateTime.UtcNow,
                Payout = playerProp.Payout,
                PlayerName = playerProp.PlayerName,
                Description = playerProp.OutcomeDescription,
                PropValue = playerProp.PropValue,
                PropBetType = playerProp.Description,
                GamblingSiteId = gamblingSiteId,
                GameId = gameId
            });
        }

        private void UpdatePlayerProp(PlayerProp playerPropInDatabase, PlayerPropOffering playerPropOffering)
        {
            playerPropInDatabase.IsAvailable = true;
            playerPropInDatabase.LastRefresh = DateTime.UtcNow;
            playerPropInDatabase.Payout = playerPropOffering.Payout;
            playerPropInDatabase.PropValue = playerPropOffering.PropValue;
        }

        private PlayerProp TryGetPlayerProp(PlayerPropOffering playerProp)
        {
            var homeTeamId = GetTeamIdFromTeamName(playerProp.HomeTeam, playerProp.Sport);
            var awayTeamId = GetTeamIdFromTeamName(playerProp.AwayTeam, playerProp.Sport);
            var gameId = GetGameId(playerProp.DateTime, homeTeamId, awayTeamId);
            if (gameId == null)
                return null;

            var gamblingSiteId = GetSiteId(playerProp.Site);

            var test = dbContext.PlayerPropRepository.Read().Where(p => p.GameId == gameId);

            return dbContext.PlayerPropRepository.Read().FirstOrDefault(p => p.GameId == gameId 
                    && p.PropBetType == playerProp.Description && p.Description == playerProp.OutcomeDescription 
                    && p.PlayerName == playerProp.PlayerName && p.GamblingSiteId == gamblingSiteId);
        }

        private bool IsCollegeSport(string sport)
        {
            return sport == "NCAAF" || sport == "NCAAB";
        }

        public void SetOfferingsToNotAvailable()
        {
            var allLines = dbContext.GameLineRepository.Read().Where(l => l.IsAvailable);
            foreach (var gameLine in allLines)
                gameLine.IsAvailable = false;

            var allBoosts = dbContext.OddsBoostRepository.Read().Where(b => b.IsAvailable);
            foreach (var boost in allBoosts)
                boost.IsAvailable = false;

            var allPlayerProps = dbContext.PlayerPropRepository.Read().Where(p => p.IsAvailable);
            foreach (var prop in allPlayerProps)
                prop.IsAvailable = false;
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
        }

        private void CreateGameLine(Guid gameId, Guid siteId, GameOffering gameOffering)
        {
            dbContext.GameLineRepository.CreateWithoutSaving(new GameLine
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
            try
            {
                var games = dbContext.GameLineRepository.Read()
                    .SingleOrDefault(gl => gl.GameId == gameId && gl.GamblingSiteId == siteId);
                return games;
            }
            catch (Exception e)
            {
                var games = dbContext.GameLineRepository.Read()
                    .Where(gl => gl.GameId == gameId && gl.GamblingSiteId == siteId).ToList();
                foreach(var game in games)
                {
                    dbContext.GameLineRepository.Delete(game);
                }
                throw e;
            }
        }

        private Guid CreateGame(DateTime gameOfferingDateTime, Guid homeTeamId, Guid awayTeamId, Guid sportId)
        {
            var game = new Game { AwayTeamId = awayTeamId, HomeTeamId = homeTeamId, TimeStamp = gameOfferingDateTime, SportId = sportId };
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
            if (IsCollegeSport(sport))
                teamName = MascotMapper.GetFullNameUsingCollege(teamName.Trim());

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
            if (sport == null)
                return dbContext.SportRepository.Read().Single(s => s.Name == "Unknown").SportId;

            return sport.SportId;
        }
    }
}
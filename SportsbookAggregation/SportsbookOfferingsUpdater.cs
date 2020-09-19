using System;
using System.Collections.Generic;
using System.Linq;
using SportsbookAggregation.Data;
using SportsbookAggregation.Data.Models;
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

        public void WriteGameOfferings(IEnumerable<GameOffering> gameOfferings)
        {
            foreach (var gameOffering in gameOfferings)
            {
                if (gameOffering.DateTime < DateTime.Now)
                    continue;
                var homeTeamId = GetTeamId(gameOffering.HomeTeam);
                var awayTeamId = GetTeamId(gameOffering.AwayTeam);
                var siteId = GetSiteId(gameOffering.Site);

                var gameId = GetGameId(gameOffering.DateTime, homeTeamId, awayTeamId) ??
                             CreateGame(gameOffering.DateTime, homeTeamId, awayTeamId);

                var gameLine = GetGameLine(gameId, siteId);
                if (gameLine == null)
                    CreateGameLine(gameId, siteId, gameOffering);
                else
                    UpdateGameLine(gameLine, gameOffering);
            }
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
            gameLine.LastRefresh = DateTime.Now;
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
                LastRefresh = DateTime.Now
            });
        }

        private GameLine GetGameLine(Guid gameId, Guid siteId)
        {
            return dbContext.GameLineRepository.Read()
                .SingleOrDefault(gl => gl.GameId == gameId && gl.GamblingSiteId == siteId);
        }

        private Guid CreateGame(DateTime gameOfferingDateTime, Guid homeTeamId, Guid awayTeamId)
        {
            var game = new Game {AwayTeamId = awayTeamId, HomeTeamId = homeTeamId, TimeStamp = gameOfferingDateTime};
            dbContext.GameRepository.Create(game);
            return game.GameId;
        }

        private Guid? GetGameId(DateTime gameTime, Guid homeTeamId, Guid awayTeamId)
        {
            var matchingGames = dbContext.GameRepository.Read()
                .Where(g => g.HomeTeamId == homeTeamId && g.AwayTeamId == awayTeamId && g.TimeStamp.Date == gameTime.Date);
            return matchingGames.FirstOrDefault(g => Math.Abs(g.TimeStamp.Hour - gameTime.Hour) <= 1)?.GameId;
        }

        private Guid GetTeamId(string teamName)
        {
            var teamNameSplit = teamName.Split(' ');
            var firstWord = teamNameSplit.First();
            var lastWord = teamNameSplit.Last();
            return dbContext.TeamRepository.Read()
                .Single(t => t.Location.StartsWith(firstWord) && t.Mascot.EndsWith(lastWord)).TeamId;
        }

        private Guid GetSiteId(string site)
        {
            return dbContext.GamblingSiteRepository.Read().Single(s => s.Name == site).GamblingSiteId;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using SportsbookAggregation.Data;
using SportsbookAggregation.SportsBooks;
using SportsbookAggregation.SportsBooks.Models;

namespace SportsbookAggregation
{
    internal static class Program
    {
        public static readonly HttpClient HttpClient = new HttpClient();

        private static void Main(string[] args)
        {
            var dbContext = new Context();

            List<ISportsBook> sportsbooks = new List<ISportsBook> { new ParxSportsBook(), new UnibetSportsBook(), new FanDuelSportsBook(), new FoxBetSportsBook(), new DraftKingsSportsBook(), new BetRiversSportsBook() };
            var gameOfferings = new List<GameOffering>();
            foreach(var sportsbook in sportsbooks)
            {
                try
                {
                    gameOfferings.AddRange(sportsbook.AggregateFutureOfferings().ToList());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Failed to Parse: " + sportsbook.GetSportsBookName());
                }
            }

            var databaseUpdater = new SportsbookOfferingsUpdater(dbContext);
            databaseUpdater.WriteGameOfferings(gameOfferings);
        }
    }
}
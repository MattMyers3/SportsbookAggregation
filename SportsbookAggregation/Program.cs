using System.Linq;
using System.Net.Http;
using SportsbookAggregation.Data;
using SportsbookAggregation.SportsBooks;

namespace SportsbookAggregation
{
    internal static class Program
    {
        public static readonly HttpClient HttpClient = new HttpClient();

        private static void Main(string[] args)
        {
            var dbContext = new Context();
            DatabaseInitializer.Initialize(dbContext);

            var gameOfferings = new FanDuelSportsBook().AggregateFutureOfferings().ToList();
            gameOfferings.AddRange(new FoxBetSportsBook().AggregateFutureOfferings());
            gameOfferings.AddRange(new DraftKingsSportsBook().AggregateFutureOfferings());
            gameOfferings.AddRange(new BetRiversSportsBook().AggregateFutureOfferings());

           var databaseUpdater = new SportsbookOfferingsUpdater(dbContext);
           databaseUpdater.WriteGameOfferings(gameOfferings);
        }
    }
}
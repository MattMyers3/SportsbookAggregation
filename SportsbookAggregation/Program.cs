using System;
using System.Net.Http;

namespace SportsbookAggregation.SportsBooks
{
    internal static class Program
    {
        public static readonly HttpClient HttpClient = new HttpClient();

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var gameOfferings = FanDuelSportsBook.AggregateFutureOfferings();
        }
    }
}
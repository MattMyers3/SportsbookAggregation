using SportsbookAggregation.Alerts;
using SportsbookAggregation.API;
using SportsbookAggregation.Config;
using SportsbookAggregation.Data;
using SportsbookAggregation.SportsBooks;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;

namespace SportsbookAggregation
{
    internal static class Program
    {
        public static HttpClient HttpClient = new HttpClient();
        public static ConfigWrapper Configuration = new ConfigWrapper();

        private static void Main(string[] args)
        {
            Configuration.ReadConfig();

            List<ISportsBook> sportsbooks = new List<ISportsBook> { new DraftKingsSportsBook(), new FanDuelSportsBook(), new FoxBetSportsBook(), new BarstoolSportsBook(), new BetAmericaSportsBook(), new CaesarsSportBook(), new BetRiversSportsBook(), new ParxSportsBook(), new UnibetSportsBook(), new SugarHouseSportsBook() };

            var gameOfferings = new List<GameOffering>();
            var oddsBoosts = new List<OddsBoostOffering>();
            var playerProps = new List<PlayerPropOffering>();

            foreach (var sportsbook in sportsbooks)
            {
                if (!Configuration.ShouldParseBook(sportsbook.GetSportsBookName()))
                    continue;
                try
                {
                    gameOfferings.AddRange(sportsbook.AggregateFutureOfferings().ToList());
                }
                catch (Exception ex)
                {
                    LogError(ex);
                    SendAlerts("Failed to parse games lines for: " + sportsbook.GetSportsBookName());
                    Console.WriteLine("Failed to parse games lines for:  " + sportsbook.GetSportsBookName());
                }
                try
                {
                    oddsBoosts.AddRange(sportsbook.AggregateOddsBoost().ToList());
                }
                catch (Exception ex)
                {
                    LogError(ex);
                    SendAlerts("Failed to parse odds boost for: " + sportsbook.GetSportsBookName());
                    Console.WriteLine("Failed to parse odds boost for: " + sportsbook.GetSportsBookName());
                }
                try
                {
                    playerProps.AddRange(sportsbook.AggregatePlayerProps().ToList());
                }
                catch (Exception ex)
                {
                    LogError(ex);
                    SendAlerts("Failed to parse player props for: " + sportsbook.GetSportsBookName());
                    Console.WriteLine("Failed to parse player props for: " + sportsbook.GetSportsBookName());
                }
            }
            try
            {
                APIService.UpdateGameLines(gameOfferings);
                using (var dbContext = new Context())
                {
                    var databaseUpdater = new SportsbookOfferingsUpdater(dbContext);
                    using (var dbContextTransaction = dbContext.Database.BeginTransaction())
                    {
                        databaseUpdater.Update(gameOfferings, oddsBoosts, playerProps);
                        dbContextTransaction.Commit();
                    }
                    using (var dbContextTransaction = dbContext.Database.BeginTransaction())
                    {
                        AlertsService.Run(dbContext);
                        dbContextTransaction.Commit();
                    }
                    //using (var dbContextTransaction = dbContext.Database.BeginTransaction())
                    //{
                    //    DataCollector.Run(dbContext);
                    //    dbContextTransaction.Commit();
                    //}
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                SendAlerts("Failed writing games to DB");
                throw ex;
            }
        }

        public static void LogError(Exception ex)
        {
            string filePath = "ErrorLog.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("Date : " + DateTime.Now.ToString());
                writer.WriteLine();

                var exception = ex;
                while (exception != null)
                {
                    writer.WriteLine(exception.GetType().FullName);
                    writer.WriteLine("Message : " + exception.Message);
                    writer.WriteLine("StackTrace : " + exception.StackTrace);

                    exception = exception.InnerException;
                }
            }
        }

        public static void WriteToConsole(string content)
        {
            if (Configuration.ReadBooleanProperty("OutputToConsole"))
                Console.WriteLine(content);
        }

        public static void SendAlerts(string content)
        {
            if (Configuration.ReadBooleanProperty("SendTexts"))
            {
                var client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                System.Net.NetworkCredential basicAuthenticationInfo = new
                   System.Net.NetworkCredential("SportsAggregation@gmail.com", "MattNick69");
                client.Credentials = basicAuthenticationInfo;

                var message = new MailMessage();
                message.From = new MailAddress("SportsAggregation@gmail.com");

                message.To.Add(new MailAddress("4102927305@vtext.com")); //Nick
                message.To.Add(new MailAddress("3015025056@vtext.com")); //Myers

                message.Subject = "PROD ALERT";
                message.Body = content;

                try
                {
                    client.Send(message);
                }
                catch
                {
                    //Sent too many alerts :(
                }
            }
        }
    }
}
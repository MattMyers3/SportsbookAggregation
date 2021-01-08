using Microsoft.Extensions.Configuration;
using SportsbookAggregation.Alerts;
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
        public static IConfigurationRoot Configuration;

        private static void Main(string[] args)
        {
            ReadConfig();
            var dbContext = new Context();
            List<ISportsBook> sportsbooks = new List<ISportsBook> { new BetAmericaSportsBook() };
            
            var gameOfferings = new List<GameOffering>();
            var oddsBoosts = new List<OddsBoostOffering>();
            var playerProps = new List<PlayerPropOffering>();

            foreach (var sportsbook in sportsbooks)
            {
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
                var databaseUpdater = new SportsbookOfferingsUpdater(dbContext);
                using (var dbContextTransaction = dbContext.Database.BeginTransaction())
                {
                    databaseUpdater.SetOfferingsToNotAvailable();
                    databaseUpdater.WriteGameOfferings(gameOfferings);
                    databaseUpdater.WriteOddsBoosts(oddsBoosts);
                    databaseUpdater.WritePlayerProps(playerProps);
                    dbContextTransaction.Commit();
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                SendAlerts("Failed writing games to DB");
                throw ex;
            }
            AlertsService.Run(dbContext);
        }

        public static void ReadConfig()
        {
            if (Configuration == null)
            {
                string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile($"appsettings.{environment}.json");
                Configuration = builder.Build();
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
            if (Convert.ToBoolean(Configuration["OutputToConsole"]))
                Console.WriteLine(content);
        }

        public static void SendAlerts(string content)
        {
            if (Convert.ToBoolean(Configuration["SendAlerts"]))
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
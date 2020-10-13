#nullable enable
using System;
using System.Data.Common;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using SportsbookAggregation.Alerts.Models;
using SportsbookAggregation.Data.Configuration;
using SportsbookAggregation.Data.Models;

namespace SportsbookAggregation.Data
{
    public class Context : DbContext
    {
        private readonly DbConnection connection;

        public Context() : this(GetDbConnection())
        {
        }

        public Context(DbConnection connection) => this.connection = connection;

        public IRepository<GamblingSite> GamblingSiteRepository => new SqlServerRepository<GamblingSite>(this);
        public IRepository<Game> GameRepository => new SqlServerRepository<Game>(this);
        public IRepository<GameLine> GameLineRepository => new SqlServerRepository<GameLine>(this);
        public IRepository<Team> TeamRepository => new SqlServerRepository<Team>(this);
        public IRepository<Sport> SportRepository => new SqlServerRepository<Sport>(this);
        public IRepository<GameResult> GameResultRepository => new SqlServerRepository<GameResult>(this);
        public IRepository<Alert> AlertRepository => new SqlServerRepository<Alert>(this);
        public IRepository<OddsBoost> OddsBoostRepository => new SqlServerRepository<OddsBoost>(this);



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GamblingSiteConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new GameLineConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new SportConfiguration());
            modelBuilder.ApplyConfiguration(new GameResultConfiguration());
            modelBuilder.ApplyConfiguration(new AlertConfiguration());
            modelBuilder.ApplyConfiguration(new OddsBoostConfiguration());

            var nbaGuid = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024");
            var nflGuid = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be");
            var mlbGuid = new Guid("a90b8447-171a-4633-b191-fa4ca83270a8");
            var mlsGuid = new Guid("c50f0844-6549-47e7-9409-921ad9bf160b");
            modelBuilder.Entity<Sport>().HasData(new Sport { SportId = mlbGuid, Name = "MLB" }, new Sport { SportId = nbaGuid, Name = "NBA" }, new Sport { Name = "NFL", SportId = nflGuid }, new Sport { Name = "MLS", SportId = mlsGuid });
            modelBuilder.Entity<Team>().HasData(
                new Team { TeamId = new Guid("327fa1ce-ebd2-42b5-8ae3-af4e1f85c31b"), SportId = nbaGuid, Location = "Atlanta", Mascot = "Hawks" },
                new Team { TeamId = new Guid("f4646032-8ce2-4115-aa17-6a3f829c48c6"), SportId = nbaGuid, Location = "Boston", Mascot = "Celtics" },
                new Team { TeamId = new Guid("51058c98-007a-4a03-a4dc-1678f39d0fe6"), SportId = nbaGuid, Location = "Brooklyn", Mascot = "Nets" },
                new Team { TeamId = new Guid("dba20e75-2763-45e0-8357-f7abdef5796e"), SportId = nbaGuid, Location = "Charlotte", Mascot = "Hornets" },
                new Team { TeamId = new Guid("9535fd86-0476-4267-964d-86b6ee59c5f1"), SportId = nbaGuid, Location = "Chicago", Mascot = "Bulls" },
                new Team { TeamId = new Guid("567d7281-3835-4ebe-9bbc-db22003ef4aa"), SportId = nbaGuid, Location = "Cleveland", Mascot = "Cavaliers" },
                new Team { TeamId = new Guid("f3449c73-2bdf-45d6-a12a-5fcdcdba9c7a"), SportId = nbaGuid, Location = "Dallas", Mascot = "Mavericks" },
                new Team { TeamId = new Guid("cc3a3123-ffcc-4575-aaf6-908bf0a29ae2"), SportId = nbaGuid, Location = "Denver", Mascot = "Nuggets" },
                new Team { TeamId = new Guid("136ffb0e-e6db-447f-ac0b-d24d0972c63a"), SportId = nbaGuid, Location = "Detroit", Mascot = "Pistons" },
                new Team { TeamId = new Guid("a7d2b876-5c8f-40c0-a245-64009f1d6875"), SportId = nbaGuid, Location = "Golden State", Mascot = "Warriors" },
                new Team { TeamId = new Guid("9cb62c80-9eed-4778-9db9-c96a3f210548"), SportId = nbaGuid, Location = "Houston", Mascot = "Rockets" },
                new Team { TeamId = new Guid("e07441a3-7862-4aa9-b102-fa9eff3a3d32"), SportId = nbaGuid, Location = "Indiana", Mascot = "Pacers" },
                new Team { TeamId = new Guid("a8427679-a566-4cb6-baf5-90f848a70ef1"), SportId = nbaGuid, Location = "Los Angeles", Mascot = "Clippers" },
                new Team { TeamId = new Guid("d96a3350-0ee1-4ebb-a3c5-7e8d9ffbdbcf"), SportId = nbaGuid, Location = "Los Angeles", Mascot = "Lakers" },
                new Team { TeamId = new Guid("0dcdcb0d-5a8f-4f06-ae40-e6c8f9405a2b"), SportId = nbaGuid, Location = "Memphis", Mascot = "Grizzlies" },
                new Team { TeamId = new Guid("553993e6-d5d2-41d1-9aa4-96282469b7f4"), SportId = nbaGuid, Location = "Miami", Mascot = "Heat" },
                new Team { TeamId = new Guid("faae94d4-821c-4089-abc9-00e59164cfe4"), SportId = nbaGuid, Location = "Milwaukee", Mascot = "Bucks" },
                new Team { TeamId = new Guid("49b08feb-f42e-4003-afea-14e5f967bf83"), SportId = nbaGuid, Location = "Minnesota", Mascot = "Timberwolves" },
                new Team { TeamId = new Guid("980e2d86-24f5-4db1-9e86-a24f69f64363"), SportId = nbaGuid, Location = "New Orleans", Mascot = "Pelicans" },
                new Team { TeamId = new Guid("aa91f18e-db7f-49b6-ae39-830232228741"), SportId = nbaGuid, Location = "New York", Mascot = "Knicks" },
                new Team { TeamId = new Guid("17c82efe-820f-47f1-beda-7ca67f77fffa"), SportId = nbaGuid, Location = "Oklahoma City", Mascot = "Thunder" },
                new Team { TeamId = new Guid("377a4678-f768-41f8-850e-437b87315b10"), SportId = nbaGuid, Location = "Orlando", Mascot = "Magic" },
                new Team { TeamId = new Guid("e3708fae-5fc1-40d6-b0bc-10330212eb46"), SportId = nbaGuid, Location = "Philadelphia", Mascot = "76ers" },
                new Team { TeamId = new Guid("9490d52f-d1d1-4ac7-87d0-0ef922f4e3e2"), SportId = nbaGuid, Location = "Phoenix", Mascot = "Suns" },
                new Team { TeamId = new Guid("a0ada57d-419d-4fec-9d72-a6d6b96fcb34"), SportId = nbaGuid, Location = "Portland", Mascot = "Trail Blazers" },
                new Team { TeamId = new Guid("adb45183-40f4-4cba-adec-062976372d31"), SportId = nbaGuid, Location = "Sacramento", Mascot = "Kings" },
                new Team { TeamId = new Guid("2578493d-1735-4427-a2e1-492f8c43fdfd"), SportId = nbaGuid, Location = "San Antonio", Mascot = "Spurs" },
                new Team { TeamId = new Guid("4d89def6-375b-4b58-8385-858ea8957576"), SportId = nbaGuid, Location = "Toronto", Mascot = "Raptors" },
                new Team { TeamId = new Guid("104981bd-8e56-4d67-bbd0-f6f1bfd50a2d"), SportId = nbaGuid, Location = "Utah", Mascot = "Jazz" },
                new Team { TeamId = new Guid("261454ae-5f16-4707-ada1-bff5095f056b"), SportId = nbaGuid, Location = "Washington", Mascot = "Wizards" },
                new Team { TeamId = new Guid("03f86ef9-e837-4d16-a869-1561dde61798"), SportId = nflGuid, Location = "Arizona", Mascot = "Cardinals" },
                new Team { TeamId = new Guid("586fe718-6743-409a-969d-d19bd36d4254"), SportId = nflGuid, Location = "Atlanta", Mascot = "Falcons" },
                new Team { TeamId = new Guid("3b88d60b-96a7-411b-a061-d4a581d7a5a6"), SportId = nflGuid, Location = "Baltimore", Mascot = "Ravens" },
                new Team { TeamId = new Guid("b62aa542-7d3b-4a85-a4e8-8b6a2d8ebefa"), SportId = nflGuid, Location = "Buffalo", Mascot = "Bills" },
                new Team { TeamId = new Guid("48259823-78c5-4c42-ace2-7d59fd6d5b67"), SportId = nflGuid, Location = "Carolina", Mascot = "Panthers" },
                new Team { TeamId = new Guid("0df55a06-1ce5-41f5-baa8-dedfc9982b14"), SportId = nflGuid, Location = "Chicago", Mascot = "Bears" },
                new Team { TeamId = new Guid("3bfcc8bb-b87d-4a1a-adf1-bf1ed1c554f5"), SportId = nflGuid, Location = "Cincinnati", Mascot = "Bengals" },
                new Team { TeamId = new Guid("450aa644-fcca-4e1e-9ed2-2eb8e87c6571"), SportId = nflGuid, Location = "Cleveland", Mascot = "Browns" },
                new Team { TeamId = new Guid("e5e561ba-70c8-4b72-bd63-d14f9e2db12c"), SportId = nflGuid, Location = "Dallas", Mascot = "Cowboys" },
                new Team { TeamId = new Guid("0b093a77-6b07-4207-b27c-848938ce522a"), SportId = nflGuid, Location = "Denver", Mascot = "Broncos" },
                new Team { TeamId = new Guid("23390e8c-e70c-48aa-9fab-6a3770d91de4"), SportId = nflGuid, Location = "Detroit", Mascot = "Lions" },
                new Team { TeamId = new Guid("7193bfbf-1aa8-480e-88e9-339312ea9da8"), SportId = nflGuid, Location = "Green Bay", Mascot = "Packers" },
                new Team { TeamId = new Guid("2f8cd4fe-dc9c-4ed1-84d7-1d0923e73ac3"), SportId = nflGuid, Location = "Houston", Mascot = "Texans" },
                new Team { TeamId = new Guid("41f2f8a9-4671-41f1-86e5-c388423b5b04"), SportId = nflGuid, Location = "Indianapolis", Mascot = "Colts" },
                new Team { TeamId = new Guid("6746d02f-0910-402b-86fc-e5a9a52d2e21"), SportId = nflGuid, Location = "Jacksonville", Mascot = "Jaguars" },
                new Team { TeamId = new Guid("d728eb6a-8a28-4c21-a50e-a226b2d5b70f"), SportId = nflGuid, Location = "Kansas City", Mascot = "Chiefs" },
                new Team { TeamId = new Guid("952efc18-905f-4ab9-8ac3-4f79b0e068e6"), SportId = nflGuid, Location = "Los Angeles", Mascot = "Chargers" },
                new Team { TeamId = new Guid("1cf88a9e-82cf-4506-8d3b-ac0b8e8915fd"), SportId = nflGuid, Location = "Los Angeles", Mascot = "Rams" },
                new Team { TeamId = new Guid("ec9d7c36-7379-4d1d-8a22-156d4ee83b2a"), SportId = nflGuid, Location = "Las Vegas", Mascot = "Raiders" },
                new Team { TeamId = new Guid("1c349295-7317-4ad8-ab5a-13275e3e03c6"), SportId = nflGuid, Location = "Miami", Mascot = "Dolphins" },
                new Team { TeamId = new Guid("69d2e5de-9793-4faa-a2a8-9bcc54e656d3"), SportId = nflGuid, Location = "Minnesota", Mascot = "Vikings" },
                new Team { TeamId = new Guid("0da464e1-f39c-4049-b312-f2968aa71ae4"), SportId = nflGuid, Location = "New England", Mascot = "Patriots" },
                new Team { TeamId = new Guid("71245471-b0ff-4381-bf35-343f698ff077"), SportId = nflGuid, Location = "New Orleans", Mascot = "Saints" },
                new Team { TeamId = new Guid("fd59c829-5712-450a-ac75-595757010acc"), SportId = nflGuid, Location = "New York", Mascot = "Giants" },
                new Team { TeamId = new Guid("d3cadd00-d44a-4840-9632-5f24d72ef9d3"), SportId = nflGuid, Location = "New York", Mascot = "Jets" },
                new Team { TeamId = new Guid("fb02cf5b-4ad9-4131-86ab-9a7f49aaad55"), SportId = nflGuid, Location = "Philadelphia", Mascot = "Eagles" },
                new Team { TeamId = new Guid("a3629bd0-3c5b-4de6-a3e4-514333fc3fa5"), SportId = nflGuid, Location = "Pittsburgh", Mascot = "Steelers" },
                new Team { TeamId = new Guid("dd82688b-9c9d-42ac-975c-d4db4a211d29"), SportId = nflGuid, Location = "Seattle", Mascot = "Seahawks" },
                new Team { TeamId = new Guid("8a7cdedd-a273-4320-b479-2eeae69694d2"), SportId = nflGuid, Location = "San Francisco", Mascot = "49ers" },
                new Team { TeamId = new Guid("360fd180-6f0e-4545-8d14-5f690944cfdc"), SportId = nflGuid, Location = "Tampa Bay", Mascot = "Buccaneers" },
                new Team { TeamId = new Guid("4c713570-bf81-4b2f-b170-3258ca86d07e"), SportId = nflGuid, Location = "Tennessee", Mascot = "Titans" },
                new Team { TeamId = new Guid("2bf36e69-9abd-40e5-92e3-3817e6c13253"), SportId = nflGuid, Location = "Washington", Mascot = "Football Team" },
                new Team { TeamId = new Guid("b80ba92d-3fea-4da0-a47f-f65cd46eb067"), SportId = mlbGuid, Location = "Arizona", Mascot = "Diamondbacks" },
                new Team { TeamId = new Guid("c6bc8fc8-6391-4af8-9032-364c86ca59d5"), SportId = mlbGuid, Location = "Atlanta", Mascot = "Braves" },
                new Team { TeamId = new Guid("764f8f26-b02b-43b5-946a-4429ff9d2ae9"), SportId = mlbGuid, Location = "Baltimore", Mascot = "Orioles" },
                new Team { TeamId = new Guid("7d297cb2-173e-4e4d-9eeb-86aecf711f7b"), SportId = mlbGuid, Location = "Boston", Mascot = "Red Sox" },
                new Team { TeamId = new Guid("1f0c79e0-65ff-4d92-8b95-7e09f875beac"), SportId = mlbGuid, Location = "Chicago", Mascot = "Cubs" },
                new Team { TeamId = new Guid("66dfad29-3097-47a0-964b-136fce7fa365"), SportId = mlbGuid, Location = "Chicago", Mascot = "White Sox" },
                new Team { TeamId = new Guid("bfb3beb9-76aa-4000-b8d5-e7c616d45c8b"), SportId = mlbGuid, Location = "Cincinnati", Mascot = "Reds" },
                new Team { TeamId = new Guid("6de834fc-509e-4989-b1d2-49c8b10c1ece"), SportId = mlbGuid, Location = "Cleveland", Mascot = "Indians" },
                new Team { TeamId = new Guid("da5a4c84-f866-49d3-960c-ead18a08346c"), SportId = mlbGuid, Location = "Colorado", Mascot = "Rockies" },
                new Team { TeamId = new Guid("61da07c9-a29c-4d0d-8375-7352458bd858"), SportId = mlbGuid, Location = "Detroit", Mascot = "Tigers" },
                new Team { TeamId = new Guid("093d9c05-cf42-4260-be44-ab6fb8399c38"), SportId = mlbGuid, Location = "Houston", Mascot = "Astros" },
                new Team { TeamId = new Guid("53ab3b55-5d3f-4991-bbf6-fa5874eeacf5"), SportId = mlbGuid, Location = "Kansas City", Mascot = "Royals" },
                new Team { TeamId = new Guid("2f47feaf-29fd-49b3-af5e-a5cd3ad1c68d"), SportId = mlbGuid, Location = "Los Angeles", Mascot = "Angels" },
                new Team { TeamId = new Guid("3105b032-1df3-48c7-be70-21a7ec36d4fd"), SportId = mlbGuid, Location = "Los Angeles", Mascot = "Dodgers" },
                new Team { TeamId = new Guid("b3d8a035-746e-42c0-9264-a97ec10d5e78"), SportId = mlbGuid, Location = "Miami", Mascot = "Marlins" },
                new Team { TeamId = new Guid("9aa7dd61-e5d7-4a80-8cef-e3b6e1a93920"), SportId = mlbGuid, Location = "Milwaukee", Mascot = "Brewers" },
                new Team { TeamId = new Guid("f3d27ac5-73cc-480d-bd44-11af1c8ddce9"), SportId = mlbGuid, Location = "Minnesota", Mascot = "Twins" },
                new Team { TeamId = new Guid("bde59215-f8be-415a-99e8-31ea7b96d2cf"), SportId = mlbGuid, Location = "New York", Mascot = "Mets" },
                new Team { TeamId = new Guid("09faad84-aa61-4376-93cc-6d98a3e2a941"), SportId = mlbGuid, Location = "New York", Mascot = "Yankees" },
                new Team { TeamId = new Guid("a8e4de87-8da4-4bb0-8232-642a059451fe"), SportId = mlbGuid, Location = "Oakland", Mascot = "Athletics" },
                new Team { TeamId = new Guid("a0ac8958-26bf-4d95-ae39-bba328daa3f1"), SportId = mlbGuid, Location = "Philadelphia", Mascot = "Phillies" },
                new Team { TeamId = new Guid("30f456f3-caf8-4582-829f-fdfc4ef6c520"), SportId = mlbGuid, Location = "Pittsburgh", Mascot = "Pirates" },
                new Team { TeamId = new Guid("f460874c-5ba5-4411-b602-239da45af489"), SportId = mlbGuid, Location = "San Diego", Mascot = "Padres" },
                new Team { TeamId = new Guid("60ecf028-f2b7-49bc-8649-776df8b8f225"), SportId = mlbGuid, Location = "San Francisco", Mascot = "Giants" },
                new Team { TeamId = new Guid("58e52fc4-c688-4ad2-9944-ee3e5f92337c"), SportId = mlbGuid, Location = "Seattle", Mascot = "Mariners" },
                new Team { TeamId = new Guid("10ed79cb-f213-403c-84da-c915ae5e4d4c"), SportId = mlbGuid, Location = "St. Louis", Mascot = "Cardinals" },
                new Team { TeamId = new Guid("53fa4e27-c75f-479a-aeba-94f8014446d1"), SportId = mlbGuid, Location = "Tampa Bay", Mascot = "Rays" },
                new Team { TeamId = new Guid("2f2cdf19-0cd7-4a35-881f-8cfbd8d4fea8"), SportId = mlbGuid, Location = "Texas", Mascot = "Rangers" },
                new Team { TeamId = new Guid("c03dd191-1cbd-4fe8-84b1-3dac7c839fff"), SportId = mlbGuid, Location = "Toronto", Mascot = "Blue Jays" },
                new Team { TeamId = new Guid("d4b12dee-abf7-41a0-b78a-d40072d5e2f8"), SportId = mlbGuid, Location = "Washington", Mascot = "Nationals" }
            );
            modelBuilder.Entity<GamblingSite>().HasData(
                new GamblingSite { GamblingSiteId = new Guid("1fcec6f7-84b3-4033-af0f-e1f2bcb8528c"), Name = "Fanduel" },
                new GamblingSite { GamblingSiteId = new Guid("585e8b23-82e7-468e-b0f3-601cd6eb7a21"), Name = "FoxBet" },
                new GamblingSite { GamblingSiteId = new Guid("ef4a3b1e-dd09-4e32-a648-097ebae237d1"), Name = "DraftKings" },
                new GamblingSite { GamblingSiteId = new Guid("a13abd89-8246-4ce9-a3e1-34eee3084748"), Name = "BetRivers" },
                new GamblingSite { GamblingSiteId = new Guid("3208224c-cbee-408f-b7d8-3ad76f70eaa9"), Name = "Unibet" },
                new GamblingSite { GamblingSiteId = new Guid("ae98bc03-bf79-491a-8d5a-23acc23908a9"), Name = "Parx" },
                new GamblingSite { GamblingSiteId = new Guid("89f19651-c30c-4846-8197-8f10e43b4ae6"), Name = "BetAmerica" },
                new GamblingSite { GamblingSiteId = new Guid("ee7f8f4c-23a7-4c35-a450-fed7cc90a6dd"), Name = "Caesars" },
                new GamblingSite { GamblingSiteId = new Guid("730346f5-e563-47bf-9230-148d25c424e9"), Name = "SugarHouse" },
                new GamblingSite { GamblingSiteId = new Guid("eda5febb-1381-411a-88e8-5db158589212"), Name = "Barstool" }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connection);
        }

        private static DbConnection GetDbConnection()
        {
            var connectionString = Environment.GetEnvironmentVariable("ConnectionString", EnvironmentVariableTarget.User);
            if (string.IsNullOrEmpty(connectionString))
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
                var configuration = builder.Build();
                connectionString = configuration.GetConnectionString("SportsbookDatabase");
            }
            Console.WriteLine($"Connection String: {connectionString}");
            return new MySqlConnection(connectionString);
        }
    }
}
#nullable enable
using System;
using System.Data.Common;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GamblingSiteConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new GameLineConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new SportConfiguration());
            modelBuilder.ApplyConfiguration(new GameResultConfiguration());

            var nbaGuid = Guid.NewGuid();
            modelBuilder.Entity<Sport>().HasData(new Sport { SportId = nbaGuid, Name = "NBA" }, new Sport { Name = "NFL", SportId = Guid.NewGuid() });
            modelBuilder.Entity<Team>().HasData(
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Atlanta", Mascot = "Hawks" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Boston", Mascot = "Celtics" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Brooklyn", Mascot = "Nets" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Charlotte", Mascot = "Hornets" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Chicago", Mascot = "Bulls" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Cleveland", Mascot = "Cavaliers" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Dallas", Mascot = "Mavericks" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Denver", Mascot = "Nuggets" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Detroit", Mascot = "Pistons" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Golden State", Mascot = "Warriors" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Houston", Mascot = "Rockets" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Indiana", Mascot = "Pacers" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Los Angeles", Mascot = "Clippers" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Los Angeles", Mascot = "Lakers" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Memphis", Mascot = "Grizzlies" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Miami", Mascot = "Heat" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Milwaukee", Mascot = "Bucks" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Minnesota", Mascot = "Timberwolves" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "New Orleans", Mascot = "Pelicans" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "New York", Mascot = "Knicks" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Oklahoma City", Mascot = "Thunder" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Orlando", Mascot = "Magic" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Philadelphia", Mascot = "76ers" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Phoenix", Mascot = "Suns" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Portland", Mascot = "Trail Blazers" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Sacramento", Mascot = "Kings" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "San Antonio", Mascot = "Spurs" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Toronto", Mascot = "Raptors" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Utah", Mascot = "Jazz" },
                new Team { TeamId = Guid.NewGuid(), SportId = nbaGuid, Location = "Washington", Mascot = "Wizards" }
            );
            modelBuilder.Entity<GamblingSite>().HasData(
                new GamblingSite { GamblingSiteId = Guid.NewGuid(), Name = "Fanduel" },
                new GamblingSite { GamblingSiteId = Guid.NewGuid(), Name = "FoxBet" },
                new GamblingSite { GamblingSiteId = Guid.NewGuid(), Name = "DraftKings" },
                new GamblingSite { GamblingSiteId = Guid.NewGuid(), Name = "BetRivers" }
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
﻿#nullable enable
using System;
using System.Data.Common;
using System.IO;
using Microsoft.Data.SqlClient;
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
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connection);
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
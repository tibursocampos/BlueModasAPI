﻿using BlueModas.Persistence.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace BlueModas.Persistence
{
    public class BlueModasContext : DbContext
    {
        private readonly string connectionString;

        public BlueModasContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=RAPHAEL-DESKTOP;" + "Initial Catalog=BlueModasDb;Integrated Security=True");
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer(connectionString);
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new CartMapping());
            modelBuilder.ApplyConfiguration(new ClientMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
        }
    }

    public class EBuffetContextFactory : IDesignTimeDbContextFactory<BlueModasContext>
    {
        public BlueModasContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? string.Empty}.json", true, true)
                .Build();

            return new BlueModasContext(configuration.GetConnectionString("BlueModas"));
        }
    }
}
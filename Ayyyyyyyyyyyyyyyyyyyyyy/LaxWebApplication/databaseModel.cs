﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaxWebApplication
{
    //Manages the connection to the database
    public class databaseModel : DbContext

    {
        //Properties map to the tables in the database
        public DbSet<laxWebApplication.gamesModel> gamesModel { get; set; }
        public DbSet<gameEventsModel> gameEventsModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb" +
                "Initial Catalog = SSLaxDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<laxWebApplication.gamesModel>().Property(data => data.homeTeam).IsRequired();
            modelBuilder.Entity<laxWebApplication.gamesModel>().Property(data => data.visitingTeam).IsRequired();
            modelBuilder.Entity<laxWebApplication.gamesModel>().Property(data => data.datePlayed).IsRequired();

            modelBuilder.Entity<gameEventsModel>().Property(data => data.team).IsRequired();
            modelBuilder.Entity<gameEventsModel>().Property(data => data.eventType).IsRequired();
            modelBuilder.Entity<gameEventsModel>().Property(data => data.homeScore).IsRequired();
            modelBuilder.Entity<gameEventsModel>().Property(data => data.visitorScore).IsRequired();
            modelBuilder.Entity<gameEventsModel>().Property(data => data.eventTime).IsRequired();
        }
    }
}
























































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































//Suck on ma titties
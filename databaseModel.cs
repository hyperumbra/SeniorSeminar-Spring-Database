using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace laxProject
{
    //Manages the connection to the database
	public class databaseModel : DBContext

	{
        //Properties map to the tables in the database
        public DbSet<gamesModel> gamesModel { get; set; }
        public DbSet<gameEventsModel> gameEventsModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb" +
                "Initial Catalog = laxDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<gamesModel>().Property(data => data.homeTeam).IsRequired();
            modelBuilder.Entity<gamesModel>().Property(data => data.visitngTeam).IsRequired();
            modelBuilder.Entity<gamesModel>().Property(data => data.datePlayed).IsRequired();

            modelBuilder.Entity<gamesModel>().Property(data => data.team).IsRequired();
            modelBuilder.Entity<gamesModel>().Property(data => data.eventType).IsRequired();
            modelBuilder.Entity<gamesModel>().Property(data => data.homeScore).IsRequired();
            modelBuilder.Entity<gamesModel>().Property(data => data.visitorScore).IsRequired();
            modelBuilder.Entity<gamesModel>().Property(data => data.eventTime).IsRequired();
        }
	}

}

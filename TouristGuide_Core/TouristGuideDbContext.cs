using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TouristGuide_Core
{
    public class TouristGuideDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=localhost;Database=TouristGuide; Trusted_Connection = True; ConnectRetryCount = 0;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>();
            modelBuilder.Entity<Food>();
            modelBuilder.Entity<Bar>();
            modelBuilder.Entity<Hotel>();
            modelBuilder.Entity<Beach>();
            modelBuilder.Entity<Sight>();
            modelBuilder.Entity<UserHistory>();
            modelBuilder.Entity<Village>();
            
        }
    }
}

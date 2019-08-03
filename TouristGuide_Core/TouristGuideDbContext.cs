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
            modelBuilder.Entity<Food>()
                .HasKey(bp => new { bp.VillageId });
            modelBuilder.Entity<Bar>()
                .HasKey(bp => new { bp.VillageId });
            modelBuilder.Entity<Hotel>()
                .HasKey(bp => new { bp.VillageId });
            modelBuilder.Entity<Beach>()
                .HasKey(bp => new { bp.VillageId});
            modelBuilder.Entity<Sight>()
                .HasKey(bp => new { bp.VillageId });
            modelBuilder.Entity<Village>();
            
        }
    }
}

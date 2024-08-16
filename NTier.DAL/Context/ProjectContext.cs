using Microsoft.EntityFrameworkCore;
using NTier.DAL.Entity;
using System.Data.Common;

namespace NTier.DAL.Context
{
    public class ProjectContext:DbContext
    {
        //ConnectionString tanımlanması
        private string connectionString = "server=localhost;database=NTierConsoleDB;Trusted_Connection=True;TrustServerCertificate=true;";

        //DbSet
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        //OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API

            //Product
            modelBuilder.Entity<Product>().Property(x => x.UnitPrice).HasColumnType("decimal(18,4)");

            base.OnModelCreating(modelBuilder);
        }

    }
}

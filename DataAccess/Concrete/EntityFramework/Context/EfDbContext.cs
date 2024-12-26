using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class EfDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer(@"Server=localhost;Database=EfCoreDemo;Trusted_Connection = True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["EfCoreDemo"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

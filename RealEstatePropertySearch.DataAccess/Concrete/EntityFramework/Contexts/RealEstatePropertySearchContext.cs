using Microsoft.EntityFrameworkCore;
using RealEstatePropertySearch.Core.Utilities.Configuration;
using RealEstatePropertySearch.DataAccess.Concrete.EntityFramework.Mappings;
using RealEstatePropertySearch.Entities.Concrete;

namespace RealEstatePropertySearch.DataAccess.Concrete.EntityFramework.Contexts
{
    public class RealEstatePropertySearchContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CoreConfig.GetConnectionString("Default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstatePropertySearch.Entities.Concrete;

namespace RealEstatePropertySearch.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(@"Products", @"dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title).HasColumnName("Title").HasColumnType("nvarchar(250)");
            builder.Property(p => p.Description).HasColumnName("Description").HasColumnType("nvarchar(250)");
            builder.Property(p => p.ImageUrl).HasColumnName("ImageUrl");
            builder.Property(p => p.Price).HasColumnName("Price");
            builder.Property(p => p.City).HasColumnName("City").HasColumnType("nvarchar(300)");
            builder.Property(p => p.District).HasColumnName("District").HasColumnType("nvarchar(200)");

            builder.Property(p => p.IsActive).HasColumnName("IsActive");
            builder.Property(p => p.CreatedOn).HasColumnName("CreatedOn");
            builder.Property(p => p.CreatedBy).HasColumnName("CreatedBy").HasColumnType("nvarchar(300)");
            builder.Property(p => p.UpdatedOn).HasColumnName("UpdatedOn");
            builder.Property(p => p.UpdatedBy).HasColumnName("UpdatedBy").HasColumnType("nvarchar(300)");
        }
    }
}

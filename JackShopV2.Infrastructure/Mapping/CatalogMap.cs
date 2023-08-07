using JackShopV2.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JackShopV2.Infrastructure.Mapping
{
    public class CatalogMap : IEntityTypeConfiguration<Catalog>
    {
        public void Configure(EntityTypeBuilder<Catalog> builder)
        {
            builder
                .HasKey(key => key.Id);

            builder
                .Property(p => p.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder
               .Property(p => p.Description)
               .HasMaxLength(50)
               .IsRequired();

            builder
               .Property(p => p.PricePerKg)
               .HasColumnType("decimal(10,2)");

            builder
              .Property(p => p.FixedFreight)
              .HasColumnType("decimal(10,2)");

            builder
             .Property(p => p.Price)
             .HasColumnType("decimal(10,2)");
        }
    }
}

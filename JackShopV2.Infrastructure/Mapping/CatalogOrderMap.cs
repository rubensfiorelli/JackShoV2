using JackShopV2.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JackShopV2.Infrastructure.Mapping
{
    public class CatalogOrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
               .HasKey(key => key.Id);

            builder
                .Property(p => p.Description)
                .HasMaxLength(300)
                .IsRequired();

            builder
               .Property(p => p.TotalPrice)
               .HasColumnType("decimal(10,2)");
        }
    }
}

using JackShopV2.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JackShopV2.Infrastructure.Mapping
{
    public class ItemsOrderMap : IEntityTypeConfiguration<ItemsOrder>
    {
        public void Configure(EntityTypeBuilder<ItemsOrder> builder)
        {
            builder
                .HasKey(key => key.Id);

            builder
                .Property(p => p.Title)
                .HasMaxLength(300)
                .IsRequired();

            builder
               .Property(p => p.Price)
               .HasColumnType("decimal(10,2)");
        }
    }
}

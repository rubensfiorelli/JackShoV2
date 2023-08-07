using JackShopV2.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JackShopV2.Infrastructure.Mapping
{
    public class DeliverAddressMap : IEntityTypeConfiguration<DeliveryAddress>
    {
        public void Configure(EntityTypeBuilder<DeliveryAddress> builder)
        {
            builder
               .HasKey(key => key.Id);

            builder
                .Property(p => p.ZipCode)
                .HasMaxLength(50)
                .IsRequired();

            builder
               .Property(p => p.Street)
               .HasMaxLength(50)
               .IsRequired();

            builder
               .Property(p => p.Street)
               .HasMaxLength(50)
               .IsRequired();

            builder
               .Property(p => p.Number)
               .HasMaxLength(50)
               .IsRequired();

            builder
               .Property(p => p.Complement)
               .HasMaxLength(50)
               .IsRequired();

            builder
               .Property(p => p.City)
               .HasMaxLength(50)
               .IsRequired();

            builder
               .Property(p => p.State)
               .HasMaxLength(50)
               .IsRequired();


        }
    }
}

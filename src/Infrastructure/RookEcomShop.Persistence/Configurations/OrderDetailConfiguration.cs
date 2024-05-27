using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Persistence.Configurations
{
    public sealed class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable(nameof(OrderDetail) + "s");

            builder.HasOne(e => e.Order)
                .WithMany(e => e.OrderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(e => e.Product)
               .WithMany(e => e.OrderDetails)
               .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}

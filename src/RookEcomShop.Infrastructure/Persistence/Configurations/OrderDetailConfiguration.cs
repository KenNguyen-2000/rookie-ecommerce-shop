using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Infrastructure.Persistence.Configurations
{
    public sealed class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable(nameof(OrderDetail) + "s");

            builder.HasOne(e => e.Order)
                .WithMany(e => e.OrderDetails)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Product)
               .WithMany(e => e.OrderDetails)
               .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}

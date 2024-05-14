using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Infrastructure.Persistence.Configurations
{
    public sealed class CartDetailConfiguration : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.ToTable(nameof(CartDetail) + "s");

            builder.HasOne(e => e.Cart)
                .WithMany(e => e.CartDetails)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(e => e.Product)
               .WithMany(e => e.CartDetails)
               .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}

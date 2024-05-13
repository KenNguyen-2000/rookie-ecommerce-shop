using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Infrastructure.Persistence.Configurations
{
    public sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User) + "s");

            builder.Property(e => e.Email)
                .HasMaxLength(100);
            builder.Property(e => e.FirstName)
                .HasMaxLength(50);
            builder.Property(e => e.LastName)
               .HasMaxLength(50);
            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(15);
        }
    }
}

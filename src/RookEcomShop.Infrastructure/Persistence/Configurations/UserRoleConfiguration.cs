using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Infrastructure.Persistence.Configurations
{
    public sealed class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable(nameof(UserRole) + "s");

            builder.Property(e => e.Name)
                .HasConversion<string>(e => Enum.GetName<RoleType>(e)!,
                                       e => (RoleType)Enum.Parse(typeof(RoleType), e))

                .HasMaxLength(50)
                .IsRequired();

            builder.HasData(
                               new UserRole { Id = 1, Name = RoleType.Admin },
                                              new UserRole { Id = 2, Name = RoleType.Buyer }
                                                                        );
        }
    }
}

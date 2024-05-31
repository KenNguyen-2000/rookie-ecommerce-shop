using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class UserRole : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        public User User { get; set; } = null!;

        public Role Role { get; set; } = null!;
    }
}

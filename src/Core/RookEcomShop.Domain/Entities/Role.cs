using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class Role : BaseEntity<Guid>
    {
        public string Name { get; set; } = null!;

        public string NormalizedName => Name.ToUpper();

        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}

using RookEcomShop.Domain.Common;
using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? HashedPassword { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? Dob { get; set; }
        public Gender Gender { get; set; } = Gender.Unisex;
        public string? AvartarUrl { get; set; }

        public virtual ICollection<UserRole> Role { get; set; } = new HashSet<UserRole>();
        public virtual Cart? Cart { get; set; }
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();
    }
}

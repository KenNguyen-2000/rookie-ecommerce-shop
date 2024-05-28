using RookEcomShop.Domain.Common;
using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.Domain.Entities
{
    public class User : BaseEntity<Guid>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public Gender Gender { get; set; } = Gender.Unisex;
        public string? AvartarUrl { get; set; }
        public string? PhoneNumber { get; set; }
        public virtual bool PhoneNumberConfirmed { get; set; }
        public string? Email { get; set; }
        public bool EmailConfirmed { get; set; }

        public virtual Cart? Cart { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();
    }
}

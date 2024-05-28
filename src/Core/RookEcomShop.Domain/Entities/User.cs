using RookEcomShop.Domain.Common;
using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public Gender Gender { get; set; } = Gender.Unisex;
        public string? AvartarUrl { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}

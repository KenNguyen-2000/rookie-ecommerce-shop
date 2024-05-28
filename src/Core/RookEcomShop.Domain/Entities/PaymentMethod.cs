using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
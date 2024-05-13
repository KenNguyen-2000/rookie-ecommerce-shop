using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual User? User { get; set; }
    }
}
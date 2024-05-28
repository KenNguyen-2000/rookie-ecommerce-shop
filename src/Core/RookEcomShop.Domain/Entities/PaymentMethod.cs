using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class PaymentMethod : BaseEntity<Guid>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
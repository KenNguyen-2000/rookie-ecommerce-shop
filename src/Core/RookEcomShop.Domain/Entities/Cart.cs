using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public int UserId { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();
    }
}

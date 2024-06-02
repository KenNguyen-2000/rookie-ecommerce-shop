using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class CartDetail : BaseEntity<Guid>
    {
        public int Quantity { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Cart Cart { get; set; } = null!;

        public static CartDetail Create(Product product, int quantity)
        {
            return new CartDetail
            {
                Product = product,
                Quantity = quantity
            };
        }
    }
}

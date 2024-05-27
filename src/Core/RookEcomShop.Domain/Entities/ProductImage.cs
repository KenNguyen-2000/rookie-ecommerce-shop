using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class ProductImage : BaseEntity
    {
        public string Url { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
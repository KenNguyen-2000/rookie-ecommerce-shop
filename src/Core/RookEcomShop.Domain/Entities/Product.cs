using RookEcomShop.Domain.Common;
using RookEcomShop.Domain.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RookEcomShop.Domain.Entities
{
    public class Product : BaseEntity<Guid>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public ProductStatus Status { get; set; } = ProductStatus.Inactive;
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }

        public virtual User? User { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
        public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}

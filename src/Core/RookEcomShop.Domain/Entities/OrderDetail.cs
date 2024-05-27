using RookEcomShop.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace RookEcomShop.Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
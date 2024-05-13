using RookEcomShop.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace RookEcomShop.Domain.Entities
{
    [Table("products")]
    public class Product : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; } = null!;
        [Column("description")]
        public string Description { get; set; } = null!;
        [Column("price")]
        public decimal Price { get; set; }
        [Column("stock_quantity")]
        public int StockQUantity { get; set; }
    }
}

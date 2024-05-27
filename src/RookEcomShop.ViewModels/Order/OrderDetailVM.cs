using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.ViewModels.Order
{
    public class OrderDetailVM
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public ProductVM Product { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

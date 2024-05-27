using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.ViewModels.Cart
{
    public class CartDetailVM : ProductVM
    {
        public int Quantity { get; set; }
        public ProductVM Product { get; set; } = null!;
    }
}

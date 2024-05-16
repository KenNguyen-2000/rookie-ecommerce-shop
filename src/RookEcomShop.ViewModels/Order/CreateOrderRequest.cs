using RookEcomShop.ViewModels.Cart;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.ViewModels.Order
{
    public class CreateOrderRequest
    {
        public IEnumerable<CartDetailVM> CartDetails { get; set; } = new List<CartDetailVM>();
    }
}

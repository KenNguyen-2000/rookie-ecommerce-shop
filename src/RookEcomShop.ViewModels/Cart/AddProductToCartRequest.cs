

namespace RookEcomShop.ViewModels.Cart
{
    public class AddProductToCartRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; } = 1;
    }
}

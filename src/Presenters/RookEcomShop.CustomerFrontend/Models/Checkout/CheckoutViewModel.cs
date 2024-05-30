using RookEcomShop.ViewModels.Cart;

namespace RookEcomShop.CustomerFrontend.Models.Checkout;

public class CheckoutViewModel
{
    public IEnumerable<CartDetailVM> Items { get; set; } = new List<CartDetailVM>();
}
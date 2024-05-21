using RookEcomShop.ViewModels.Cart;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.CustomerFrontend.Services.Cart
{
    public interface ICartApiClient
    {
        Task<IEnumerable<CartDetailVM>> GetProductsInCart();
    }
}

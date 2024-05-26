using FluentResults;
using RookEcomShop.ViewModels.Cart;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.CustomerFrontend.Services.Cart
{
    public interface ICartApiClient
    {
        Task<IEnumerable<CartDetailVM>> GetProductsInCart();
        Task AddProductToCart(AddProductToCartRequest request);
        Task RemoveProductFromCart(int productId);
    }
}

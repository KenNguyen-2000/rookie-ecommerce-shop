using RookEcomShop.ViewModels.Contracts.Cart;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.Services.Cart
{
    public interface ICartApiClient
    {
        Task<IEnumerable<CartDetailDto>> GetProductsInCart();
        Task AddProductToCart(AddProductToCartRequest request);
        Task RemoveProductFromCart(Guid productId);
    }
}

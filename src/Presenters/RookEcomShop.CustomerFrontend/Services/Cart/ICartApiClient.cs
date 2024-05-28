using RookEcomShop.ViewModels.Cart;

namespace RookEcomShop.CustomerFrontend.Services.Cart
{
    public interface ICartApiClient
    {
        Task<IEnumerable<CartDetailVM>> GetProductsInCart();
        Task AddProductToCart(AddProductToCartRequest request);
        Task RemoveProductFromCart(Guid productId);
    }
}

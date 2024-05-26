using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Order;

namespace RookEcomShop.CustomerFrontend.Services.Categories
{
    public interface IOrdersApiClient
    {
        Task<IList<OrderVM>> GetOrdersAsync();
        Task CreateOrderAsync();
    }
}

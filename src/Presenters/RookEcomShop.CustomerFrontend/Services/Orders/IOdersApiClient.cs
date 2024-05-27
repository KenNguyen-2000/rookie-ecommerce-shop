using RookEcomShop.ViewModels.Order;

namespace RookEcomShop.CustomerFrontend.Services.Orders
{
    public interface IOrdersApiClient
    {
        Task<IList<OrderVM>> GetOrdersAsync();
        Task CreateOrderAsync();
    }
}

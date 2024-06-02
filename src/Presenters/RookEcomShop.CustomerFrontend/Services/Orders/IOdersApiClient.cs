using RookEcomShop.ViewModels.Contracts.Order;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.Services.Orders
{
    public interface IOrdersApiClient
    {
        Task<IList<OrderDto>> GetOrdersAsync();
        Task CreateOrderAsync(CreateOrderRequest request);
    }
}

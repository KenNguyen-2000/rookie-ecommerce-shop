using RookEcomShop.ViewModels.Contracts.Product;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.ViewModels.ViewModels
{
    public class ProductDetailsVM
    {
        public ProductDto Product { get; set; } = null!;
        public IEnumerable<OrderDto> Reviews { get; set; } = new List<OrderDto>();
        public AddToCartInput AddToCartInput { get; set; } = new AddToCartInput();
    }
}
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.Models.Home
{
    public class HomeViewModel
    {
        public PaginatedList<ProductDto> ProductDatas { get; set; } = null!;
    }
}
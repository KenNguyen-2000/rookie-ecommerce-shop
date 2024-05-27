using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.CustomerFrontend.Models.Home
{
    public class HomeViewModel
    {
        public PaginatedList<ProductVM> ProductDatas { get; set; } = null!;
    }
}
using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.CustomerFrontend.Models.Home
{
    public class HomeViewModel
    {
        public PaginatedList<ProductVM> ProductDatas { get; set; } = null!;
    }
}
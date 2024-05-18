using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.CustomerFrontend.Models.Home
{
    public class HomeViewModel
    {
        public IList<ProductVM> Products { get; set; } = new List<ProductVM>();
    }
}
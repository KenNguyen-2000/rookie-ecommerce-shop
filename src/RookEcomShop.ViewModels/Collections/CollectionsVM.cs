using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.ViewModels.Collections
{
    public class CollectionsVM
    {
        public PaginatedList<ProductVM> Products { get; set; } = null!;
        public CategoryVM Category { get; set; } = null!;
    }
}
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.ViewModels.ViewModels
{
    public class CollectionsVM
    {
        public PaginatedList<ProductDto> Products { get; set; } = null!;
        public CategoryDto Category { get; set; } = null!;
    }
}
using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.ViewModels.Dto
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public ProductStatus Status { get; set; }
        public int StockQuantity { get; set; }
        public CategoryDto Category { get; set; } = null!;
        public IEnumerable<string> ImgUrls { get; set; } = new List<string>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

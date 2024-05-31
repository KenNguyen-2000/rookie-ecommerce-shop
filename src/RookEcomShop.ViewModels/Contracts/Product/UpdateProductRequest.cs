using Microsoft.AspNetCore.Http;
using RookEcomShop.Domain.Common.Enums;
namespace RookEcomShop.ViewModels.Contracts.Product
{
    public class UpdateProductRequest
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string CategoryName { get; set; } = null!;
        public ProductStatus Status { get; set; }
        public IFormFileCollection? Images { get; set; }
    }
}

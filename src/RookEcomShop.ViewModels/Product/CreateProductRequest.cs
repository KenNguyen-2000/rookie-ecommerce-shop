using Microsoft.AspNetCore.Http;

namespace RookEcomShop.ViewModels.Product
{
    public class CreateProductRequest
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string CategoryName { get; set; } = null!;
        public int UserId { get; set; }
        public IFormFileCollection? Images { get; set; }
    }
}

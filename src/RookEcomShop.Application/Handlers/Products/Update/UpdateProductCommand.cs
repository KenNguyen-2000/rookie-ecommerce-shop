using MediatR;
using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.Application.Handlers.Products.Update
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public ProductStatus Status { get; set; }
    }
}

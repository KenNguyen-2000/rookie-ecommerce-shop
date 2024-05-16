using MediatR;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetByCategoryName
{
    public class GetProductsByCategoryNameQuery : IRequest<IEnumerable<ProductVM>>
    {
        public string CategoryName { get; set; } = null!;
    }
}

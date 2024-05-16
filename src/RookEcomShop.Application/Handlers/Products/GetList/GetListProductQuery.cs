using MediatR;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetList
{
    public class GetListProductQuery : IRequest<IEnumerable<ProductVM>>
    {
        public string? SearchTerm { get; set; } = String.Empty;
    }
}

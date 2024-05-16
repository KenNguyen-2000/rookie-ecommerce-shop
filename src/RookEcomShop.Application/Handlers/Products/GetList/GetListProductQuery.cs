using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetList
{
    public class GetListProductQuery : IRequest<Result<IEnumerable<ProductVM>>>
    {
        public string? SearchTerm { get; set; } = String.Empty;
    }
}

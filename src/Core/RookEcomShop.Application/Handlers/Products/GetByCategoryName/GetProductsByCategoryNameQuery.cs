using FluentResults;
using MediatR;
using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Products.GetByCategoryName
{
    public class GetProductsByCategoryNameQuery : IRequest<Result<PaginatedList<ProductDto>>>
    {
        public string CategoryName { get; set; } = null!;
        public ProductQueryDto QueryObject { get; set; } = null!;
    }
}

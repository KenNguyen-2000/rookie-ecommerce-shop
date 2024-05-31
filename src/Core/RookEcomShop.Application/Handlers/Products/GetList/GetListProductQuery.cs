using FluentResults;
using MediatR;
using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Products.GetList
{
    public class GetListProductQuery : IRequest<Result<PaginatedList<ProductDto>>>
    {
        public ProductQueryDto QueryObject { get; set; } = new ProductQueryDto();
    }
}

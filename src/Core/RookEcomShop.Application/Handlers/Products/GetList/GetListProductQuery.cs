using FluentResults;
using MediatR;
using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetList
{
    public class GetListProductQuery : IRequest<Result<PaginatedList<ProductVM>>>
    {
        public ProductQueryDto QueryObject { get; set; } = new ProductQueryDto();
    }
}

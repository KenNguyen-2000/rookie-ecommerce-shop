using FluentResults;
using MediatR;
using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetList
{
    public record GetListProductQuery(
        QueryDto QueryObject) : IRequest<Result<PaginatedList<ProductVM>>>;
}

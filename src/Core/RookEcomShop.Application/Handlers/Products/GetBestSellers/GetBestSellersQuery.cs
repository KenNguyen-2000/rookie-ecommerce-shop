using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Products.GetBestSellers;

public class GetBestSellersQuery : IRequest<Result<IEnumerable<ProductDto>>>
{
    public int Count { get; set; } = 10;
}
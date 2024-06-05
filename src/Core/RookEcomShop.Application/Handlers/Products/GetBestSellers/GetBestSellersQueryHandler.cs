using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Products.GetBestSellers;

public class GetBestSellersQueryHandler : IRequestHandler<GetBestSellersQuery, Result<IEnumerable<ProductDto>>>
{
    private readonly IProductRepository _productRepository;

    public GetBestSellersQueryHandler(
        IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Result<IEnumerable<ProductDto>>> Handle(GetBestSellersQuery request, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetListBestSellersAsync(request.Count, cancellationToken);

        return Result.Ok(products.Select(ProductsMapper.MapToProductVM));
    }
}
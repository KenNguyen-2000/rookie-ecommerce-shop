using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Products.GetBestReviews
{
    public class GetBestReviewsQueryHandler : IRequestHandler<GetBestReviewsQuery, Result<IEnumerable<ProductDto>>>
    {
        private readonly IProductRepository _productRepository;

        public GetBestReviewsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Result<IEnumerable<ProductDto>>> Handle(GetBestReviewsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetListBestReviewsAsync(request.Count, cancellationToken);

            return Result.Ok(products.Select(ProductsMapper.MapToProductVM));
        }
    }
}
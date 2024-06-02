using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Products.GetList
{
    public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, Result<PaginatedList<ProductDto>>>
    {
        private readonly IProductRepository _productRepository;

        public GetListProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Result<PaginatedList<ProductDto>>> Handle(GetListProductQuery query, CancellationToken cancellationToken)
        {
            var products = await _productRepository
                                    .GetListAsync(filter: null, query.QueryObject, cancellationToken);

            PaginatedList<ProductDto> productVMs = ProductsMapper.MapToPaginatedProductVM(products);

            return Result.Ok(productVMs);
        }
    }
}

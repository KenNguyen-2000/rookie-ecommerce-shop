using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Persistence.Repositories;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Products.GetById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Result<ProductDto>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Result<ProductDto>> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            var product = await _productRepository
                                    .GetByIdAsync(query.Id, cancellationToken)
                                    .ThrowIfNullAsync($"Product with id {query.Id}");

            return Result.Ok(ProductsMapper.MapToProductVM(product));
        }
    }
}

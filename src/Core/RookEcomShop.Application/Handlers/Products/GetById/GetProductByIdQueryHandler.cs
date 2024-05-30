using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Result<ProductVM>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Result<ProductVM>> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(query.Id);

            if (product == null)
                throw new NotFoundException($"Product with id {query.Id} not found");

            return Result.Ok(ProductsMapper.MapToProductVM(product));
        }
    }
}

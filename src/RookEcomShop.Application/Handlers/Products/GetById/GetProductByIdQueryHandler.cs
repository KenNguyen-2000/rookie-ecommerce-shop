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

            return Result.Ok(new ProductVM
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                Category = new CategoryVM
                {
                    Id = product.Category.Id,
                    Name = product.Category.Name
                },
                ImgUrls = new()
            });
        }
    }
}

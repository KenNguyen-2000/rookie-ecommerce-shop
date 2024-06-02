using FluentResults;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Data;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using System.Linq.Expressions;

namespace RookEcomShop.Application.Handlers.Products.GetByCategoryName
{
    public class GetProductsByCategoryNameQueryHandler : IRequestHandler<GetProductsByCategoryNameQuery, Result<PaginatedList<ProductDto>>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductsByCategoryNameQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Result<PaginatedList<ProductDto>>> Handle(GetProductsByCategoryNameQuery query, CancellationToken cancellationToken)
        {
            var paginatedProducts = await _productRepository.GetListAsync(FilterBySearch(query), query.QueryObject, cancellationToken);

            PaginatedList<ProductDto> productVMs = ProductsMapper.MapToPaginatedProductVM(paginatedProducts);

            return Result.Ok(productVMs);
        }

        private static Expression<Func<Product, bool>> FilterBySearch(GetProductsByCategoryNameQuery query)
        {
            if (query.QueryObject.SearchTerm == null)
            {
                return p => p.Category.Name == query.CategoryName;
            }
            return p =>
                                p.Category.Name == query.CategoryName &&
                                (p.Name.Contains(query.QueryObject.SearchTerm) || p.Description.Contains(query.QueryObject.SearchTerm));
        }

    }
}

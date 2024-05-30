using FluentResults;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Data;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Product;
using System.Linq.Expressions;

namespace RookEcomShop.Application.Handlers.Products.GetByCategoryName
{
    public class GetProductsByCategoryNameQueryHandler : IRequestHandler<GetProductsByCategoryNameQuery, Result<PaginatedList<ProductVM>>>
    {
        private readonly IRookEcomShopDbContext _context;
        private readonly IProductRepository _productRepository;

        public GetProductsByCategoryNameQueryHandler(IRookEcomShopDbContext context, IProductRepository productRepository)
        {
            _context = context;
            _productRepository = productRepository;
        }

        public async Task<Result<PaginatedList<ProductVM>>> Handle(GetProductsByCategoryNameQuery query, CancellationToken cancellationToken)
        {
            var paginatedProducts = await _productRepository.GetListAsync(FilterBySearch(query), query.QueryObject, cancellationToken);
            IQueryable<Product> productsQuery = _context.Products
                .Where(p => p.Category.Name == query.CategoryName)
                .Include(p => p.Category)
                .Include(p => p.ProductImages);
            PaginatedList<ProductVM> productVMs = ProductsMapper.MapToPaginatedProductVM(paginatedProducts);

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

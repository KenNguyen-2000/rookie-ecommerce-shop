using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Data;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Product;
using System.Linq.Expressions;

namespace RookEcomShop.Application.Handlers.Products.GetList
{
    public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, Result<PaginatedList<ProductVM>>>
    {
        private readonly IRookEcomShopDbContext _context;

        public GetListProductQueryHandler(IRookEcomShopDbContext context)
        {
            _context = context;
        }

        public async Task<Result<PaginatedList<ProductVM>>> Handle(GetListProductQuery query, CancellationToken cancellationToken)
        {
            IQueryable<Product> productsQuery = _context.Products;
            productsQuery = FilterProductBySearchTerm(query, productsQuery);
            productsQuery = FilterProductByCategory(query, productsQuery);
            productsQuery = SortProducts(query, productsQuery);

            var productResponsesQuery = productsQuery.Select(p => new ProductVM
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                Status = p.Status,
                Category = new CategoryVM
                {
                    Id = p.Category.Id,
                    Name = p.Category.Name,
                    Description = p.Category.Description,
                    ParentId = p.Category.CategoryId
                },
                ImgUrls = p.ProductImages.Select(i => i.Url).ToList()
            });

            var products = await PaginatedList<ProductVM>.CreateAsync(productResponsesQuery, query.QueryObject.Page, query.QueryObject.PageSize);

            return Result.Ok(products);
        }

        private static IQueryable<Product> SortProducts(GetListProductQuery query, IQueryable<Product> productsQuery)
        {
            if (query.QueryObject.SortOrder?.ToLower() == "desc")
            {
                productsQuery = productsQuery.OrderByDescending(GetSortProperty(query));
            }
            else
            {
                productsQuery = productsQuery.OrderBy(GetSortProperty(query));
            }

            return productsQuery;
        }

        private static IQueryable<Product> FilterProductByCategory(GetListProductQuery query, IQueryable<Product> productsQuery)
        {
            if (!string.IsNullOrWhiteSpace(query.QueryObject.CategoryName))
            {
                productsQuery = productsQuery.Where(p => p.Category.Name == query.QueryObject.CategoryName);
            }

            return productsQuery;
        }

        private static IQueryable<Product> FilterProductBySearchTerm(GetListProductQuery query, IQueryable<Product> productsQuery)
        {
            if (!string.IsNullOrWhiteSpace(query.QueryObject.SearchTerm))
            {
                productsQuery = productsQuery.Where(p =>
                    p.Name.Contains(query.QueryObject.SearchTerm) ||
                    p.Description.Contains(query.QueryObject.SearchTerm));
            }

            return productsQuery;
        }

        private static Expression<Func<Product, object>> GetSortProperty(GetListProductQuery request) =>
       request.QueryObject.SortColumn?.ToLower() switch
       {
           "name" => product => product.Name,
           "description" => product => product.Description,
           _ => product => product.Id
       };
    }
}

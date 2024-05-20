using System.Linq.Expressions;
using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Data;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Product;

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

            if (!string.IsNullOrWhiteSpace(query.SearchTerm))
            {
                productsQuery = productsQuery.Where(p =>
                    p.Name.Contains(query.SearchTerm) ||
                    p.Description.Contains(query.SearchTerm));
            }

            if (query.SortOrder?.ToLower() == "desc")
            {
                productsQuery = productsQuery.OrderByDescending(GetSortProperty(query));
            }
            else
            {
                productsQuery = productsQuery.OrderBy(GetSortProperty(query));
            }

            var productResponsesQuery = productsQuery.Select(p => new ProductVM
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                Category = new CategoryVM
                {
                    Id = p.Category.Id,
                    Name = p.Category.Name
                },
                ImgUrls = p.ProductImages.Select(i => i.Url).ToList()
            });

            var products = await PaginatedList<ProductVM>.CreateAsync(productResponsesQuery, query.Page, query.PageSize);

            return Result.Ok(products);
        }

        private static Expression<Func<Product, object>> GetSortProperty(GetListProductQuery request) =>
       request.SortColumn?.ToLower() switch
       {
           "name" => product => product.Name,
           "description" => product => product.Description,
           _ => product => product.Id
       };
    }
}

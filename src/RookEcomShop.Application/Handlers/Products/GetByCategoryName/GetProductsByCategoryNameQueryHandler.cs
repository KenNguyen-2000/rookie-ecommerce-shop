﻿using System.Linq.Expressions;
using FluentResults;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Data;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetByCategoryName
{
    public class GetProductsByCategoryNameQueryHandler : IRequestHandler<GetProductsByCategoryNameQuery, Result<PaginatedList<ProductVM>>>
    {
        private readonly IRookEcomShopDbContext _context;


        public GetProductsByCategoryNameQueryHandler(IRookEcomShopDbContext context)
        {
            _context = context;
        }

        public async Task<Result<PaginatedList<ProductVM>>> Handle(GetProductsByCategoryNameQuery query, CancellationToken cancellationToken)
        {
            IQueryable<Product> productsQuery = _context.Products
                .Where(p => p.Category.Name == query.CategoryName)
                .Include(p => p.Category)
                .Include(p => p.ProductImages);

            if (!string.IsNullOrWhiteSpace(query.SearchTerm))
            {
                productsQuery = productsQuery.Where(p =>
                    p.Category.Name == query.CategoryName &&
                    (p.Name.Contains(query.SearchTerm) || p.Description.Contains(query.SearchTerm)))
                    .Include(p => p.Category)
                .Include(p => p.ProductImages);
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

        private static Expression<Func<Product, object>> GetSortProperty(GetProductsByCategoryNameQuery request) =>
     request.SortColumn?.ToLower() switch
     {
         "name" => product => product.Name,
         "description" => product => product.Description,
         _ => product => product.Id
     };
    }
}

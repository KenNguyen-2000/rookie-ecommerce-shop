using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using System.Linq.Expressions;

namespace RookEcomShop.Persistence.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {

        public ProductRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public void SoftDelete(Product entity)
        {
            _dbContext.Entry(entity).Property("IsDeleted").CurrentValue = true;
        }

        public async Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Products
                .Include(p => p.Category)
                .Include(p => p.ProductImages)
                .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
        }

        public async Task<PaginatedList<Product>> GetListAsync(Expression<Func<Product, bool>>? filter, ProductQueryDto productQueryDto, CancellationToken cancellationToken = default)
        {
            IQueryable<Product> query = _dbContext.Products
                .Include(p => p.Category)
                .Include(p => p.ProductImages);


            if (filter != null)
            {
                query = query.Where(filter);
            }
            query = FilterProducts(productQueryDto, query);
            query = QueryHelper<ProductQueryDto, Product>.SortValues(productQueryDto, query, GetSortProperty(productQueryDto));

            var totalCount = query.Count();
            var products = await QueryHelper<ProductQueryDto, Product>.PaginateValues(productQueryDto, query).ToListAsync(cancellationToken);

            return PaginatedList<Product>.Create(products, productQueryDto.Page, productQueryDto.PageSize, totalCount);
        }

        public async Task<IEnumerable<Product>> GetListBestSellersAsync(int count = 10, CancellationToken cancellationToken = default)
        {
            var products = await _dbContext.Products
                .Include(p => p.Category)
                .Include(p => p.ProductImages)
                .Include(p => p.OrderDetails)
                .OrderByDescending(p => p.OrderDetails.Count)
                .Take(count)
                .ToListAsync(cancellationToken);

            return products;
        }

        private static IQueryable<Product> FilterProducts(ProductQueryDto productQueryDto, IQueryable<Product> query)
        {
            query = FilterProductByCategory(productQueryDto, query);
            query = FilterProductByStatus(productQueryDto, query);
            query = FilterProductBySearchTerm(productQueryDto, query);
            return query;
        }

        private static IQueryable<Product> FilterProductByCategory(ProductQueryDto query, IQueryable<Product> products)
        {
            if (!string.IsNullOrWhiteSpace(query.CategoryName))
            {
                products = products.Where(p => p.Category.Name == query.CategoryName);
            }

            return products;
        }

        private static IQueryable<Product> FilterProductBySearchTerm(ProductQueryDto query, IQueryable<Product> products)
        {
            if (!string.IsNullOrWhiteSpace(query.SearchTerm))
            {
                products = products.Where(p =>
                    p.Name.ToLower().Contains(query.SearchTerm.ToLower()) ||
                    p.Description.ToLower().Contains(query.SearchTerm.ToLower()));
            }

            return products;
        }

        private static IQueryable<Product> FilterProductByStatus(ProductQueryDto query, IQueryable<Product> products)
        {
            if (query.Status != null)
            {
                products = products.Where(p => p.Status == query.Status);
            }

            return products;
        }

        private static Expression<Func<Product, object>> GetSortProperty(ProductQueryDto queryDto) =>
            queryDto.SortColumn?.ToLower() switch
            {
                "name" => product => product.Name,
                "description" => product => product.Description,
                "price" => product => product.Price,
                "stockquantity" => product => product.StockQuantity,
                "createdAt" => product => product.CreatedAt,
                _ => product => product.Id
            };

        public async Task<IEnumerable<Product>> GetListBestReviewsAsync(int count = 10, CancellationToken cancellationToken = default)
        {
            IQueryable<Product> query = _dbContext.Products
                .Include(p => p.Category)
                .Include(p => p.ProductImages)
                .Include(p => p.Reviews);

            if (query.Count() > 0)
            {
                query = query
                .OrderByDescending(p => p.Reviews.Count);
            }
            var products = await query.Take(count)
                .ToListAsync(cancellationToken);

            return products;
        }
    }
}

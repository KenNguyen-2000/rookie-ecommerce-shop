using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using System.Linq.Expressions;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        void SoftDelete(Product entity);
        Task<PaginatedList<Product>> GetListAsync(Expression<Func<Product, bool>>? filter = null, ProductQueryDto queryDto = default!, CancellationToken cancellationToken = default);
        Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Product>> GetListBestSellersAsync(int count = 10, CancellationToken cancellationToken = default);
        Task<IEnumerable<Product>> GetListBestReviewsAsync(int count = 10, CancellationToken cancellationToken = default);
    }
}

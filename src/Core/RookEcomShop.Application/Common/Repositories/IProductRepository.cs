using System.Linq.Expressions;
using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        void SoftDelete(Product entity);
        Task<PaginatedList<Product>> GetListAsync(Expression<Func<Product, bool>>? filter = null, ProductQueryDto queryDto = default!, CancellationToken cancellationToken = default);
        Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}

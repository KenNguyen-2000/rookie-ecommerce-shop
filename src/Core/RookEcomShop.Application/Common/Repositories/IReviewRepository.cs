using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using System.Linq.Expressions;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IReviewRepository : IBaseRepository<Review>
    {
        Task<PaginatedList<Review>> GetListAsync(Expression<Func<Review, bool>>? filter = null, QueryDto queryDto = default!, CancellationToken cancellationToken = default);
        Task<Review?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
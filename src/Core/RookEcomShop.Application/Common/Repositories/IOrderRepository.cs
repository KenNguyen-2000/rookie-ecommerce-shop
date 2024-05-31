using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using System.Linq.Expressions;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        Task<PaginatedList<Order>> GetListAsync(Expression<Func<Order, bool>>? filter = null, QueryDto queryDto = default, CancellationToken cancellationToken = default);
        Task<Order> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}

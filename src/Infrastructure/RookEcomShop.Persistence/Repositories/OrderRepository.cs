using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using System.Linq.Expressions;

namespace RookEcomShop.Persistence.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public Task<Order?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return _dbContext.Orders
                .Include(o => o.OrderDetails)
                    .ThenInclude(oD => oD.Product)
                    .ThenInclude(p => p.Category)
                .Include(o => o.User)
                .Include(o => o.PaymentTransaction)
                .FirstOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
        }

        public async Task<PaginatedList<Order>> GetListAsync(Expression<Func<Order, bool>>? filter, QueryDto queryDto = default!, CancellationToken cancellationToken = default)
        {
            IQueryable<Order> query = _dbContext.Orders;

            if (filter != null)
            {
                query = query.Where(filter);
            }



            var orders = await query
                .Include(o => o.User)
                .Include(o => o.OrderDetails)
                    .ThenInclude(oD => oD.Product)
                    .ThenInclude(p => p.Category)
                .Include(o => o.PaymentTransaction)
                .ToListAsync(cancellationToken);

            return PaginatedList<Order>.Create(orders);
        }
    }
}

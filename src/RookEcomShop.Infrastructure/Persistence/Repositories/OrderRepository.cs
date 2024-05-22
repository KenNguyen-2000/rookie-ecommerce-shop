using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Infrastructure.Persistence.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Order>> GetListAsync(Expression<Func<Order, bool>>? filter, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Orders
            .Include(o => o.OrderDetails)
                .ThenInclude(oD => oD.Product)
                .ThenInclude(p => p.Category)
            .Where(filter)
            .ToListAsync(cancellationToken);
        }
    }
}

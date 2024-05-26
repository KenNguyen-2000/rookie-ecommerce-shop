using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Infrastructure.Persistence.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Review>> GetListAsync(Expression<Func<Review, bool>>? filter, CancellationToken cancellationToken = default)
        {
            return filter != null ? await _dbContext.Reviews
            .Include(r => r.User)
            .Where(filter)
            .ToListAsync(cancellationToken) : await _dbContext.Reviews
            .Include(r => r.User)
            .ToListAsync(cancellationToken);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using System.Linq.Expressions;

namespace RookEcomShop.Persistence.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Review>> GetListAsync(Expression<Func<Review, bool>>? filter, CancellationToken cancellationToken = default)
        {
            return filter != null ? await _dbContext.Reviews
            .Where(filter)
            .ToListAsync(cancellationToken) : await _dbContext.Reviews
            .ToListAsync(cancellationToken);
        }
    }
}
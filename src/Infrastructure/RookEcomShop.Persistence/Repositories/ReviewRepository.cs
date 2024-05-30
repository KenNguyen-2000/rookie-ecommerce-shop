using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using System.Linq.Expressions;

namespace RookEcomShop.Persistence.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public async Task<Review?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Reviews.Include(r => r.User).FirstOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
        }

        public async Task<PaginatedList<Review>> GetListAsync(
            Expression<Func<Review, bool>>? filter,
            QueryDto queryDto,
            CancellationToken cancellationToken = default)
        {
            IQueryable<Review> query = _dbContext.Reviews.Include(r => r.User);
            if (filter != null)
            {
                query = query.Where(filter);
            }

            query = QueryHelper<QueryDto, Review>.SortValues(queryDto,
                                                             query,
                                                             GetSortProperty(queryDto));

            var totalCount = await query.CountAsync(cancellationToken);
            var reviews = await QueryHelper<QueryDto, Review>.PaginateValues(queryDto, query).ToListAsync();

            return PaginatedList<Review>.Create(
                reviews,
                queryDto.Page,
                queryDto.PageSize,
                totalCount);
        }

        private static Expression<Func<Review, object>> GetSortProperty(QueryDto queryDto) =>
      queryDto.SortColumn?.ToLower() switch
      {
          "user" => review => review.User.FirstName,
          _ => review => review.Id
      };

    }
}
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Common;

namespace RookEcomShop.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity<Guid>
    {
        protected readonly RookEcomShopDbContext _dbContext;

        public BaseRepository(RookEcomShopDbContext context)
        {
            _dbContext = context;
        }

        public virtual void Create(T entity)
        {
            _dbContext.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _dbContext.Remove(entity);
        }

        // public virtual async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        // {
        //     return await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        // }

        // public virtual async Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>>? filter, QueryDto? queryDto, CancellationToken cancellationToken = default)
        // {
        //     IQueryable<T> query = _dbContext.Set<T>();

        //     if (filter != null)
        //     {
        //         query.Where(filter);
        //     }

        //     if (queryDto != null)
        //     {
        //         query = query.Skip(queryDto.Page).Take(queryDto.PageSize);
        //     }

        //     return await query.ToListAsync(cancellationToken);
        // }

        public virtual void Update(T entity)
        {
            _dbContext.Update(entity);
        }
    }
}

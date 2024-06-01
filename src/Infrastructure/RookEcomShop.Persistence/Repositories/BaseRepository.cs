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

        public virtual void Update(T entity)
        {
            _dbContext.Update(entity);
        }
    }
}

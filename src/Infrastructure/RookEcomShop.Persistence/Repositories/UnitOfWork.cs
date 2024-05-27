using RookEcomShop.Application.Common.Repositories;

namespace RookEcomShop.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RookEcomShopDbContext _dbContext;

        public UnitOfWork(RookEcomShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public void Commit()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        //public IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity
        //{
        //    throw new NotImplementedException();
        //}

        //public void Rollback()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}

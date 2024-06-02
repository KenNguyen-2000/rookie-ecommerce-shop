using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Common;

namespace RookEcomShop.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RookEcomShopDbContext _dbContext;

        public UnitOfWork(RookEcomShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }


        public IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity<Guid>
        {
            return new BaseRepository<TEntity>(_dbContext);
        }

        public void Rollback()
        {
            foreach (EntityEntry entry in _dbContext.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}

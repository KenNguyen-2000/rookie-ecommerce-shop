using RookEcomShop.Domain.Common;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
        IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity<Guid>;
        Task SaveAsync(CancellationToken cancellationToken = default);
        void Dispose();
    }
}

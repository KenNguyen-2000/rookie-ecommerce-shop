namespace RookEcomShop.Application.Common.Repositories
{
    public interface IUnitOfWork
    {
        //void Commit();
        //void Rollback();
        //IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;
        Task SaveAsync(CancellationToken cancellationToken = default);
    }
}

using RookEcomShop.Domain.Common;
using System.Linq.Expressions;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>>? filter = null, CancellationToken cancellationToken = default);
    }
}

using RookEcomShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void Rollback();
        IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;
        Task SaveAsync(CancellationToken cancellationToken = default);
    }
}

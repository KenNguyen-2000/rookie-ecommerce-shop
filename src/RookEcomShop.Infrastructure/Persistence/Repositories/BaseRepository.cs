using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Infrastructure.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly RookEcomShopDbContext _dbContext;

        public BaseRepository(RookEcomShopDbContext context)
        {
            _dbContext = context;
        }

        public void Create(T entity)
        {
            _dbContext.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Remove(entity);
        }

        public async Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>>? filter, CancellationToken cancellationToken = default)
        {
            return filter != null 
                ? await _dbContext.Set<T>().Where(filter).ToListAsync(cancellationToken)
                : await _dbContext.Set<T>().ToListAsync(cancellationToken);
        }

        public void Update(T entity)
        {
            _dbContext.Update(entity);
        }
    }
}

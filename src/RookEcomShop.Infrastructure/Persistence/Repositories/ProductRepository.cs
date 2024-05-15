using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {

        public ProductRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public void SoftDelete(Product entity)
        {
            _dbContext.Entry(entity).Property("IsDeleted").CurrentValue = true;
        }

    }
}

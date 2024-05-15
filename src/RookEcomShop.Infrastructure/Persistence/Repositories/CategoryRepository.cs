using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public async Task<Category?> GetCategoryByName(string name)
        {
            return await _dbContext.Categories.FirstOrDefaultAsync(e => e.Name.Equals(name));
        }
    }
}

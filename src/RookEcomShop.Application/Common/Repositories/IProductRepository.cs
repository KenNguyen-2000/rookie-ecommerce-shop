using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        void SoftDelete(Product entity);
    }
}

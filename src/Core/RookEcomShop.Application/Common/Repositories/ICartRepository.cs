using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface ICartRepository : IBaseRepository<Cart>
    {
        Task<Cart?> GetCartByUserIdAsync(int userId);

    }
}

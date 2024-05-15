using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetUserByEmailAsync(string email);
        Task<User?> GetUserByIdAsync(int id);
    }
}

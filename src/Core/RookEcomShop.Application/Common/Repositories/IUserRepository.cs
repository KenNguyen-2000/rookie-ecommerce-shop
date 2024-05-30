using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.User;
using System.Linq.Expressions;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<IEnumerable<UserDto>> GetUsersAsync(Expression<Func<User, bool>>? filter = null);
        Task<UserDto?> GetByIdAsync(Guid userId);
        Task<IEnumerable<UserDto>> GetUsersByIds(IEnumerable<Guid> userIds);
        Task<PaginatedList<UserDto>> GetListAsync(Expression<Func<User, bool>>? filter = null, QueryDto queryDto = default!, CancellationToken cancellationToken = default);
    }
}

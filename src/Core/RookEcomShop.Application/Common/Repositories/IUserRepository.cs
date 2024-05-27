using RookEcomShop.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserDto>> GetUsers();
    }
}

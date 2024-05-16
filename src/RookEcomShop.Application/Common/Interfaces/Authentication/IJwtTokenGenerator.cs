using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}

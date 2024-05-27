using IdentityServer4.Models;

namespace RookEcomShop.Infrastructure.Services
{
    public interface IProfileService
    {
        Task GetProfileDataAsync(ProfileDataRequestContext context);
        Task IsActiveAsync(IsActiveContext context);
    }
}

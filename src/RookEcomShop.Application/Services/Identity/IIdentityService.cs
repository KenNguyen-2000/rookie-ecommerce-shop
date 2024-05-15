using RookEcomShop.ViewModels.Api;
using RookEcomShop.ViewModels.Identity;

namespace RookEcomShop.Application.Services.Identity
{
    public interface IIdentityService
    {
        public Task<Response<string>> RegisterAsync(RegisterRequest registerRequest);
    }
}

using RookEcomShop.ViewModels.Api;
using RookEcomShop.ViewModels.Identity;

namespace RookEcomShop.Application.Handlers.Identity
{
    public interface IIdentityService
    {
        public Task<Response<string>> RegisterAsync(RegisterRequest registerRequest);
    }
}

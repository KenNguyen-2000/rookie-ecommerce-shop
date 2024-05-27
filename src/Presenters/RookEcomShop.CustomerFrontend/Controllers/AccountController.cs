using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Accounts;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountApiClient _accountApiClient;

        public AccountController(IAccountApiClient accountApiClient)
        {
            _accountApiClient = accountApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _accountApiClient.GetUser();
            return View();
        }
        public IActionResult SignIn()
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/" }, "oidc");
        }

        public IActionResult Logout()
        {
            return SignOut(new AuthenticationProperties { RedirectUri = "/" }, "Cookies", "oidc");
        }

        [Authorize]
        public ActionResult MyProfile()
        {
            return View();
        }
    }
}

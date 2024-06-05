using IdentityServer4.Events;
using IdentityServer4.Models;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RookEcomShop.IdentityServer.Domain;
using RookEcomShop.IdentityServer.Models.Account;
using RookEcomShop.IdentityServer.Models.Account.Login;

namespace RookEcomShop.IdentityServer.Pages.Account.Login
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        public LoginViewModel LoginViewModel { get; set; } = default!;
        [BindProperty]
        public LoginInputModel LoginInputModel { get; set; } = default!;

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IIdentityServerInteractionService _interaction;
        private readonly IClientStore _clientStore;
        private readonly IAuthenticationSchemeProvider _schemeProvider;
        private readonly IEventService _events;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IIdentityServerInteractionService interaction,
            IClientStore clientStore,
            IAuthenticationSchemeProvider schemeProvider,
            IEventService events)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _interaction = interaction;
            _clientStore = clientStore;
            _schemeProvider = schemeProvider;
            _events = events;
        }

        public async Task<IActionResult> OnGet(string returnUrl)
        {
            if (User?.Identity?.IsAuthenticated == true)
            {
                return Redirect(returnUrl ?? "~/");
            }
            // build a model so we know what to show on the login page
            await BuildLoginViewModelAsync(returnUrl);
            if (LoginViewModel.IsExternalLoginOnly)
            {
                // we only have one option for logging in and it's an external provider
                return RedirectToAction("Challenge", "External", new { scheme = LoginViewModel.ExternalLoginScheme, returnUrl });
            }

            return Page();
        }

        public async Task<IActionResult> OnPost(string button)
        {
            // check if we are in the context of an authorization request
            var context = await _interaction.GetAuthorizationContextAsync(LoginInputModel.ReturnUrl);
            Console.WriteLine("Model Valid: " + JsonConvert.SerializeObject(LoginInputModel).ToString() + button);

            // the user clicked the "cancel" button
            if (button != "login")
            {
                if (context != null)
                {
                    // if the user cancels, send a result back into IdentityServer as if they 
                    // denied the consent (even if this client does not require consent).
                    // this will send back an access denied OIDC error response to the client.
                    await _interaction.DenyAuthorizationAsync(context, AuthorizationError.AccessDenied);

                    // we can trust model.ReturnUrl since GetAuthorizationContextAsync returned non-null
                    if (context.IsNativeClient())
                    {
                        // The client is native, so this change in how to
                        // return the response is for better UX for the end user.
                        return this.LoadingPage("Redirect", LoginInputModel.ReturnUrl);
                    }

                    return Redirect(LoginInputModel.ReturnUrl);
                }
                else
                {
                    // since we don't have a valid context, then we just go back to the home page
                    return Redirect("~/");
                }
            }

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(LoginInputModel.Username, LoginInputModel.Password, LoginInputModel.RememberLogin, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(LoginInputModel.Username);
                    await _events.RaiseAsync(new UserLoginSuccessEvent(user.UserName, user.Id.ToString(), user.UserName, clientId: context?.Client.ClientId));

                    if (context != null)
                    {
                        if (context.IsNativeClient())
                        {
                            // The client is native, so this change in how to
                            // return the response is for better UX for the end user.
                            return this.LoadingPage("Redirect", LoginInputModel.ReturnUrl);
                        }

                        // we can trust model.ReturnUrl since GetAuthorizationContextAsync returned non-null
                        return Redirect(LoginInputModel.ReturnUrl);
                    }

                    // request for a local page
                    if (Url.IsLocalUrl(LoginInputModel.ReturnUrl))
                    {
                        return Redirect(LoginInputModel.ReturnUrl);
                    }
                    else if (string.IsNullOrEmpty(LoginInputModel.ReturnUrl))
                    {
                        return Redirect("https://localhost:7019/account/signin");
                    }
                    else
                    {
                        // user might have clicked on a malicious link - should be logged
                        throw new Exception("invalid return URL");
                    }
                }

                await _events.RaiseAsync(new UserLoginFailureEvent(LoginInputModel.Username, "invalid credentials", clientId: context?.Client.ClientId));
                ViewData["ErrorMessage"] = "Username or password is incorrect!";
                ModelState.AddModelError(string.Empty, AccountOptions.InvalidCredentialsErrorMessage);
            }

            // something went wrong, show form with error
            await BuildLoginViewModelAsync(LoginInputModel);
            return Page();
        }

        /*****************************************/
        /* helper APIs for the AccountController */
        /*****************************************/
        private async Task BuildLoginViewModelAsync(string? returnUrl)
        {
            LoginInputModel = new LoginInputModel
            {
                ReturnUrl = returnUrl
            };

            var context = await _interaction.GetAuthorizationContextAsync(returnUrl);
            if (context?.IdP != null && await _schemeProvider.GetSchemeAsync(context.IdP) != null)
            {
                var local = context.IdP == IdentityServer4.IdentityServerConstants.LocalIdentityProvider;

                // this is meant to short circuit the UI and only trigger the one external IdP
                LoginViewModel = new LoginViewModel
                {
                    EnableLocalLogin = local,
                    Username = context?.LoginHint,
                };

                if (!local)
                {
                    LoginViewModel.ExternalProviders = new[] { new ExternalProvider { AuthenticationScheme = context.IdP } };
                }

                return;
            }

            var schemes = await _schemeProvider.GetAllSchemesAsync();

            var providers = schemes
                .Where(x => x.DisplayName != null)
                .Select(x => new ExternalProvider
                {
                    DisplayName = x.DisplayName ?? x.Name,
                    AuthenticationScheme = x.Name
                }).ToList();

            var allowLocal = true;
            if (context?.Client.ClientId != null)
            {
                var client = await _clientStore.FindEnabledClientByIdAsync(context.Client.ClientId);
                if (client != null)
                {
                    allowLocal = client.EnableLocalLogin;

                    if (client.IdentityProviderRestrictions != null && client.IdentityProviderRestrictions.Any())
                    {
                        providers = providers.Where(provider => client.IdentityProviderRestrictions.Contains(provider.AuthenticationScheme)).ToList();
                    }
                }
            }

            LoginViewModel = new LoginViewModel
            {
                AllowRememberLogin = AccountOptions.AllowRememberLogin,
                EnableLocalLogin = allowLocal && AccountOptions.AllowLocalLogin,
                ReturnUrl = returnUrl,
                Username = context?.LoginHint,
                ExternalProviders = providers.ToArray()
            };
        }

        private async Task BuildLoginViewModelAsync(LoginInputModel model)
        {
            await BuildLoginViewModelAsync(model.ReturnUrl);
        }


    }
}

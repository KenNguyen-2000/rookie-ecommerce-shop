using IdentityModel;
using IdentityServer4.Events;
using IdentityServer4.Extensions;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RookEcomShop.IdentityServer.Domain;
using RookEcomShop.IdentityServer.Models.Account;
using RookEcomShop.IdentityServer.Models.Account.Logout;

namespace RookEcomShop.IdentityServer.Pages.Account.Logout
{
    public class IndexModel : PageModel
    {
        public LoggedOutViewModel LoggedOutViewModel { get; set; } = default!;
        public LogoutViewModel LogoutViewModel { get; set; } = default!;
        [BindProperty]
        public LogoutInputModel LogoutInputModel { get; set; } = default!;

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IIdentityServerInteractionService _interaction;
        private readonly IEventService _events;

        public IndexModel(
            SignInManager<ApplicationUser> signInManager,
            IIdentityServerInteractionService interaction,
            IEventService events)
        {
            _signInManager = signInManager;
            _interaction = interaction;
            _events = events;
        }
        public async Task<IActionResult> OnGet(string logoutId, string? returnUrl)
        {
            await BuildLoggedOutViewModelAsync(logoutId);

            if (User?.Identity.IsAuthenticated == true)
            {
                // delete local authentication cookie
                await _signInManager.SignOutAsync();

                // raise the logout event
                await _events.RaiseAsync(new UserLogoutSuccessEvent(User.GetSubjectId(), User.GetDisplayName()));
            }

            // check if we need to trigger sign-out at an upstream identity provider
            if (LoggedOutViewModel.TriggerExternalSignout)
            {
                // build a return URL so the upstream provider will redirect back
                // to us after the user has logged out. this allows us to then
                // complete our single sign-out processing.
                string url = Url.Action("Logout", new { logoutId = LoggedOutViewModel.LogoutId });

                // this triggers a redirect to the external provider for sign-out
                return SignOut(new AuthenticationProperties { RedirectUri = url }, LoggedOutViewModel.ExternalAuthenticationScheme);
            }

            if (LoggedOutViewModel.PostLogoutRedirectUri != null)
            {
                return Redirect(LoggedOutViewModel.PostLogoutRedirectUri);
            }


            return Redirect($"~/Account/Login");
        }

        public async Task<IActionResult> OnPost()
        {
            // build a model so the logged out page knows what to display
            await BuildLoggedOutViewModelAsync(LogoutInputModel.LogoutId);

            if (User?.Identity.IsAuthenticated == true)
            {
                // delete local authentication cookie
                await _signInManager.SignOutAsync();

                // raise the logout event
                await _events.RaiseAsync(new UserLogoutSuccessEvent(User.GetSubjectId(), User.GetDisplayName()));
            }

            // check if we need to trigger sign-out at an upstream identity provider
            if (LoggedOutViewModel.TriggerExternalSignout)
            {
                // build a return URL so the upstream provider will redirect back
                // to us after the user has logged out. this allows us to then
                // complete our single sign-out processing.
                string url = Url.Action("Logout", new { logoutId = LoggedOutViewModel.LogoutId });

                // this triggers a redirect to the external provider for sign-out
                return SignOut(new AuthenticationProperties { RedirectUri = url }, LoggedOutViewModel.ExternalAuthenticationScheme);
            }

            return Page();
        }

        private async Task BuildLogoutViewModelAsync(string logoutId)
        {
            LogoutViewModel = new LogoutViewModel { LogoutId = logoutId, ShowLogoutPrompt = AccountOptions.ShowLogoutPrompt };

            if (User?.Identity.IsAuthenticated != true)
            {
                // if the user is not authenticated, then just show logged out page
                LogoutViewModel.ShowLogoutPrompt = false;
            }

            var context = await _interaction.GetLogoutContextAsync(logoutId);
            if (context?.ShowSignoutPrompt == false)
            {
                // it's safe to automatically sign-out
                LogoutViewModel.ShowLogoutPrompt = false;
                return;
            }

            // show the logout prompt. this prevents attacks where the user
            // is automatically signed out by another malicious web page.
            return;
        }

        private async Task BuildLoggedOutViewModelAsync(string logoutId)
        {
            // get context information (client name, post logout redirect URI and iframe for federated signout)
            var logout = await _interaction.GetLogoutContextAsync(logoutId);

            LoggedOutViewModel = new LoggedOutViewModel
            {
                AutomaticRedirectAfterSignOut = AccountOptions.AutomaticRedirectAfterSignOut,
                PostLogoutRedirectUri = logout?.PostLogoutRedirectUri,
                ClientName = string.IsNullOrEmpty(logout?.ClientName) ? logout?.ClientId : logout?.ClientName,
                SignOutIframeUrl = logout?.SignOutIFrameUrl,
                LogoutId = logoutId
            };

            if (User?.Identity.IsAuthenticated == true)
            {
                var idp = User.FindFirst(JwtClaimTypes.IdentityProvider)?.Value;
                if (idp != null && idp != IdentityServer4.IdentityServerConstants.LocalIdentityProvider)
                {
                    var providerSupportsSignout = await HttpContext.GetSchemeSupportsSignOutAsync(idp);
                    if (providerSupportsSignout)
                    {
                        if (LoggedOutViewModel.LogoutId == null)
                        {
                            // if there's no current logout context, we need to create one
                            // this captures necessary info from the current logged in user
                            // before we signout and redirect away to the external IdP for signout
                            LoggedOutViewModel.LogoutId = await _interaction.CreateLogoutContextAsync();
                        }

                        LoggedOutViewModel.ExternalAuthenticationScheme = idp;
                    }
                }
            }

        }
    }
}

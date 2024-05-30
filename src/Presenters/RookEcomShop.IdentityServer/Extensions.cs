using IdentityServer4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RookEcomShop.IdentityServer.Models;

namespace RookEcomShop.IdentityServer
{
    public static class Extensions
    {
        /// <summary>
        /// Checks if the redirect URI is for a native client.
        /// </summary>
        /// <returns></returns>
        public static bool IsNativeClient(this AuthorizationRequest context)
        {
            return !context.RedirectUri.StartsWith("https", StringComparison.Ordinal)
               && !context.RedirectUri.StartsWith("http", StringComparison.Ordinal);
        }
        internal static IActionResult LoadingPage(this PageModel page, string viewName, string redirectUri)
        {
            page.HttpContext.Response.StatusCode = 200;
            page.HttpContext.Response.Headers["Location"] = "";

            return page.RedirectToPage("/Redirect/Index", new { RedirectUri = redirectUri });
        }
    }
}

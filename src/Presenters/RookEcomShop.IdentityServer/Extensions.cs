using IdentityServer4.Models;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.IdentityServer.Models;
using RookEcomShop.Infrastructure.IdentityServer;
using RookEcomShop.Persistence;

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
        public static IActionResult LoadingPage(this Controller controller, string viewName, string redirectUri)
        {
            controller.HttpContext.Response.StatusCode = 200;
            controller.HttpContext.Response.Headers["Location"] = "";

            return controller.View(viewName, new RedirectViewModel { RedirectUrl = redirectUri });
        }

        public static void AddIdentityServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllersWithViews();
            var clientUrls = new Dictionary<string, string>
            {
                ["Mvc"] = builder.Configuration["ClientUrl:Mvc"]!,
                ["Swagger"] = builder.Configuration["ClientUrl:Swagger"]!,
                ["React"] = builder.Configuration["ClientUrl:React"]!
            };

            var identityBuilderService = builder.Services
                .AddIdentityServer(options =>
                {
                    options.Events.RaiseErrorEvents = true;
                    options.Events.RaiseInformationEvents = true;
                    options.Events.RaiseFailureEvents = true;
                    options.Events.RaiseSuccessEvents = true;

                    // see https://identityserver4.readthedocs.io/en/latest/topics/resources.html
                    options.EmitStaticAudienceClaim = true;
                })
                .AddInMemoryIdentityResources(Config.IdentityResources)
                .AddInMemoryApiScopes(Config.ApiScopes)
                .AddInMemoryApiResources(Config.ApiResources)
                .AddInMemoryClients(Config.Clients(clientUrls))
                .AddAspNetIdentity<ApplicationUser>();


            // not recommended for production - you need to store your key material somewhere secure
            if (builder.Environment.IsDevelopment()) identityBuilderService.AddDeveloperSigningCredential();

        }


    }
}

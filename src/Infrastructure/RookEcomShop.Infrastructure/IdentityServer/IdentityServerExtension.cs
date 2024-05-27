using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RookEcomShop.Infrastructure;
using RookEcomShop.Persistence;

namespace RookEcomShop.Infrastructure.IdentityServer
{
    public static class IdentityServerExtension
    {
        public static void ConfigureIdentityServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllersWithViews();
            var clientUrls = new Dictionary<string, string>
            {
                ["Mvc"] = builder.Configuration["ClientUrl:Mvc"]!,
                ["Swagger"] = builder.Configuration["ClientUrl:Swagger"]!,
                ["React"] = builder.Configuration["ClientUrl:React"]!
            };

            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;

            builder.Services.AddDbContext<RookEcomShopDbContext>(opt =>
                      opt.UseSqlServer(connectionString,
                          providerOptions =>
                          {
                              providerOptions.EnableRetryOnFailure();
                          }));

            builder.Services
                .AddIdentity<ApplicationUser, IdentityRole<int>>()
                .AddEntityFrameworkStores<RookEcomShopDbContext>()
                .AddDefaultTokenProviders();

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

using IdentityServer4.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Infrastructure.Persistence;

namespace RookEcomShop.Infrastructure.Extensions.IdentityServer
{
    public static class IdentityServerExtension
    {
        public static void AddConfigIdentityServices(this WebApplicationBuilder builder)
        {
            var clientUrls = new Dictionary<string, string>
            {
                ["Mvc"] = builder.Configuration["ClientUrl:Mvc"]!,
                ["Swagger"] = builder.Configuration["ClientUrl:Swagger"]!,
                ["React"] = builder.Configuration["ClientUrl:React"]!
            };
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;

            builder.Services.AddControllersWithViews();


            builder.Services
                .AddIdentity<User, IdentityRole<int>>()
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
                .AddInMemoryIdentityResources(IdentityServerConfig.IdentityResources)
                .AddInMemoryApiScopes(IdentityServerConfig.ApiScopes)
                .AddInMemoryApiResources(IdentityServerConfig.ApiResources)
                .AddInMemoryClients(IdentityServerConfig.Clients(clientUrls))
                .AddAspNetIdentity<User>();


            // not recommended for production - you need to store your key material somewhere secure
            if (builder.Environment.IsDevelopment()) identityBuilderService.AddDeveloperSigningCredential();

            builder.Services.AddAuthentication();
        }
    }
}

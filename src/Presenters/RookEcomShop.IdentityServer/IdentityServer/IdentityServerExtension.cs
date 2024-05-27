using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.IdentityServer.Persistence;
using RookEcomShop.Infrastructure;
using RookEcomShop.Infrastructure.IdentityServer;

namespace RookEcomShop.IdentityServer.IdentityServer
{
    public static class IdentityServerExtension
    {
        public static void AddConfigIdentityServices(this WebApplicationBuilder builder)
        {
            builder.Services
                .AddControllersWithViews();


            var clientUrls = new Dictionary<string, string>
            {
                ["Mvc"] = builder.Configuration["ClientUrl:Mvc"]!,
                ["Swagger"] = builder.Configuration["ClientUrl:Swagger"]!,
                ["React"] = builder.Configuration["ClientUrl:React"]!
            };
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;

            builder.Services.AddDbContext<IdentityServerDbContext>(opt =>
                      opt.UseSqlServer(connectionString,
                          providerOptions =>
                          {
                              providerOptions.EnableRetryOnFailure();
                          }));

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Bearer";
                options.DefaultAuthenticateScheme = "Bearer";
            });

            builder.Services
                .AddIdentity<ApplicationUser, IdentityRole<int>>()
                .AddEntityFrameworkStores<IdentityServerDbContext>()
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

            builder.ConfigureIdentityService();
            

            builder.Services.AddAuthorization(option =>
            {
                option.AddPolicy("Bearer", policy =>
                {
                    policy.RequireAuthenticatedUser();
                });
            });
        }
    }
}

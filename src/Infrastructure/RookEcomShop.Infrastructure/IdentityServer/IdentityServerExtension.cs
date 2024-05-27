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
        public static void AddConfigIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection")!;

            services.AddDbContext<RookEcomShopDbContext>(opt =>
                      opt.UseSqlServer(connectionString,
                          providerOptions =>
                          {
                              providerOptions.EnableRetryOnFailure();
                          }));

            services
                .AddIdentity<ApplicationUser, IdentityRole<int>>()
                .AddEntityFrameworkStores<RookEcomShopDbContext>()
                .AddDefaultTokenProviders();
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IdentityModel.Tokens.Jwt;
using RookEcomShop.Infrastructure.ConfigurationOptions;

namespace RookEcomShop.Infrastructure.Authentication
{
    public static class AuthenticationExtension
    {
        public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration, AppSettings appSettings)
        {
            var JwtSettings = new JwtSettings();
            configuration.Bind(JwtSettings.SectionName, JwtSettings);

            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            services.AddAuthentication("Bearer")
                    .AddJwtBearer("Bearer", options =>
                    {
                        options.Audience = appSettings.IdentityServerSettings.Audience; //api resource name
                        options.Authority = appSettings.IdentityServerSettings.Authority;
                        options.RequireHttpsMetadata = false;

                    });

            services.AddAuthorization(option =>
            {
                option.AddPolicy("ApiScope", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", "rookEcomShop.api", "profile", "openid");
                });
                option.AddPolicy("Admin", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireRole("Admin");
                });
            });
        }
    }
}

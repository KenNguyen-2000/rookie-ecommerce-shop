using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace RookEcomShop.Infrastructure.Swagger
{
    public static class SwaggerExtension
    {
        public static void AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo { Title = "Rookie Ecommerce Shop Api", Version = "v1" });

                option.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        AuthorizationCode = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri("https://localhost:7280/connect/authorize"),
                            TokenUrl = new Uri("https://localhost:7280/connect/token"),
                            Scopes = new Dictionary<string, string>
                            {
                                {"rookEcomShop.api", "rookEcomShop.api"},
                                {"profile", "profile" },
                                {"openid", "openid" }
                            }
                        }
                    }
                });



                option.OperationFilter<AuthorizeCheckOperationFilter>();
            });
        }
    }
}
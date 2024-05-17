using Microsoft.OpenApi.Models;

namespace RookEcomShop.Api.Extensions.Configurations
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new() { Title = "Rookie Ecommerce Shop Api", Version = "v1" });

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
                                {"rookEcomShop.api", "RookEcomShop Api"}
                            }
                        }
                    }
                });

                option.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new[] { "rookEcomShop.api" }
                    }
                });

            });
        }
     }
}

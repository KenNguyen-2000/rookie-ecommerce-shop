using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Infrastructure.Extensions.Authentication
{
    public static class AuthenticationExtension
    {
        public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var JwtSettings = new JwtSettings();
            configuration.Bind(JwtSettings.SectionName, JwtSettings);

            services
                .AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer("Bearer", jwtBearerOptions =>
                {
                    jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSettings.Secret)),
                        ValidateIssuer = true,
                        ValidIssuer = configuration["JwtSettings:Issuer"],
                        ValidateAudience = true,
                        ValidAudience = configuration["JwtSettings:Audience"],
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                });
        }
    }
}

﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Infrastructure.Persistence;

namespace RookEcomShop.IndentityServer
{
    public static class IdenServerExtension
    {
        public static void AddConfigIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            var clientUrls = new Dictionary<string, string>
            {
                ["Mvc"] = configuration["ClientUrl:Mvc"]!,
                ["Swagger"] = configuration["ClientUrl:Swagger"]!,
                ["React"] = configuration["ClientUrl:React"]!
            };

            services.AddControllersWithViews();

            services.AddDbContext<RookEcomShopDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services
                .AddIdentity<User, IdentityRole<int>>()
                .AddEntityFrameworkStores<RookEcomShopDbContext>()
                .AddDefaultTokenProviders();

            services
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
                            .AddInMemoryClients(IdentityServerConfig.Clients(clientUrls))
                            .AddAspNetIdentity<User>();


        }
    }
}
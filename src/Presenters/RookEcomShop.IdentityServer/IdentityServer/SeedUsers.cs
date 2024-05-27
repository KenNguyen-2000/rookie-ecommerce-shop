// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.IdentityServer.Persistence;
using RookEcomShop.Infrastructure.IdentityServer;
using Serilog;
using System.Security.Claims;

namespace RookEcomShop.IdentityServer.IdentityServer
{
    public class SeedUsers
    {
        public static async void EnsureSeedData(string connectionString)
        {
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddDbContext<IdentityServerDbContext>(options =>
               options.UseSqlServer(connectionString));

            services.AddIdentity<ApplicationUser, IdentityRole<int>>()
                .AddEntityFrameworkStores<IdentityServerDbContext>()
                .AddDefaultTokenProviders();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                using (var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    try
                    {
                        var context = scope.ServiceProvider.GetService<IdentityServerDbContext>();
                        context.Database.Migrate();

                        var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();
                        IdentityRole<int> adminRole, buyerRole;
                        CreateRoles(roleManager, out adminRole, out buyerRole);

                        await CreateAliceUser(userMgr, buyerRole!);
                        await CreateBobUser(userMgr, adminRole!);
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }



                }
            }
        }

        private static void CreateRoles(RoleManager<IdentityRole<int>> roleManager, out IdentityRole<int>? adminRole, out IdentityRole<int>? buyerRole)
        {
            adminRole = roleManager.FindByNameAsync("Admin").Result;
            if (adminRole == null)
            {
                adminRole = new IdentityRole<int>
                {
                    Name = "Admin",
                };
                _ = roleManager.CreateAsync(new IdentityRole<int>("Admin")).Result;
            }

            buyerRole = roleManager.FindByNameAsync("Buyer").Result;
            if (buyerRole == null)
            {
                buyerRole = new IdentityRole<int>
                {
                    Name = "Buyer",
                };
                _ = roleManager.CreateAsync(new IdentityRole<int>("Buyer")).Result;
            }
        }

        private static async Task CreateAliceUser(UserManager<ApplicationUser> userMgr, IdentityRole<int> buyerRole)
        {
            var alice = userMgr.FindByNameAsync("alice").Result;
            if (alice == null)
            {
                alice = new ApplicationUser
                {
                    FirstName = "Alice",
                    LastName = "Smith",
                    UserName = "alice",
                    Email = "AliceSmith@email.com",
                    EmailConfirmed = true,
                };
                var result = userMgr.CreateAsync(alice, "Pass123$").Result;
                await userMgr.AddToRoleAsync(alice, "Admin");
                if (!result.Succeeded)
                {
                    Console.WriteLine(result.Errors.First().Description);
                    throw new Exception(result.Errors.First().Description);
                }
                result = userMgr.AddClaimsAsync(alice, new Claim[]{
                            new Claim(JwtClaimTypes.Name, "Alice Smith"),
                            new Claim(JwtClaimTypes.GivenName, "Alice"),
                            new Claim(JwtClaimTypes.FamilyName, "Smith"),
                            new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                        }).Result;
                if (!result.Succeeded)
                {
                    Console.WriteLine(result.Errors.First().Description);
                    throw new Exception(result.Errors.First().Description);
                }
                Log.Debug("alice created");
            }
            else
            {
                Log.Debug("alice already exists");
            }
            if (!userMgr.IsInRoleAsync(alice, buyerRole.Name!).Result)
                _ = userMgr.AddToRolesAsync(alice, [buyerRole.Name!]).Result;
        }

        private static async Task CreateBobUser(UserManager<ApplicationUser> userMgr, IdentityRole<int> adminRole)
        {
            var bob = await userMgr.FindByNameAsync("bob");
            if (bob == null)
            {
                bob = new ApplicationUser
                {
                    FirstName = "Bob",
                    LastName = "Smith",
                    UserName = "bob",
                    Email = "BobSmith@email.com",
                    EmailConfirmed = true
                };
                var result = userMgr.CreateAsync(bob, "Pass123$").Result;

                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                result = userMgr.AddClaimsAsync(bob, new Claim[]{
                            new Claim(JwtClaimTypes.Name, "Bob Smith"),
                            new Claim(JwtClaimTypes.GivenName, "Bob"),
                            new Claim(JwtClaimTypes.FamilyName, "Smith"),
                            new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                            new Claim("location", "somewhere"),
                            new Claim(JwtClaimTypes.Role, "Admin")
                        }).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
                Log.Debug("bob created");
            }
            else
            {

                Log.Debug("bob already exists");
            }
            if (!userMgr.IsInRoleAsync(bob, adminRole.Name!).Result)
                _ = userMgr.AddToRolesAsync(bob, [adminRole.Name!]).Result;
        }
    }
}
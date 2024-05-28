// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using FluentResults;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Entities;
using RookEcomShop.IdentityServer.Domain;
using RookEcomShop.IdentityServer.Persistence;
using RookEcomShop.Persistence;
using Serilog;
using System.Security.Claims;

namespace RookEcomShop.Infrastructure.IdentityServer
{
    public class SeedUsers
    {
        public static async Task EnsureSeedData(string connectionString, string rookEcomConnection)
        {
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddDbContext<IdentityServerDbContext>(options =>
               options.UseSqlServer(connectionString));

            services.AddDbContext<RookEcomShopDbContext>(options =>
                options.UseSqlServer(rookEcomConnection));
            services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<IdentityServerDbContext>()
                .AddDefaultTokenProviders();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                using (var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    try
                    {
                        var context = scope.ServiceProvider.GetService<IdentityServerDbContext>();
                        var appContext = scope.ServiceProvider.GetService<RookEcomShopDbContext>();
                        context?.Database.Migrate();
                        appContext?.Database.Migrate();

                        var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();
                        var roles = await CreateRoles(appContext, roleManager);

                        await CreateAliceUser(appContext, userMgr, roles.Item2);

                        await CreateBobUser(appContext,userMgr, roles.Item1);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }



                }
            }
        }

        private static async Task CreateAliceUser(RookEcomShopDbContext appContext, UserManager<ApplicationUser> userMgr, IdentityRole<Guid> buyerRole)
        {
            var alice = userMgr.FindByNameAsync("alice").Result;
            var appAlice = await appContext.Users.FirstOrDefaultAsync(u => u.FirstName == "Alice");
            if (alice == null && appAlice == null)
            {
                alice = new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Alice",
                    LastName = "Smith",
                    UserName = "alice",
                    Email = "AliceSmith@email.com",
                    EmailConfirmed = true,
                };
                appAlice = new User
                {
                    Id = alice.Id,
                    FirstName = alice.FirstName,
                    LastName = alice.LastName,
                    Email = alice.Email,
                    Username = alice.UserName,
                    EmailConfirmed = true,
                };

                var result = userMgr.CreateAsync(alice, "Pass123$").Result;
                
                if (!result.Succeeded)
                {
                    Console.WriteLine(result.Errors.First().Description);
                    throw new Exception(result.Errors.First().Description);
                }

                var appBuyerRole = await appContext.Roles.FirstOrDefaultAsync(r => r.Name == "Buyer");
                appAlice.UserRoles.Add(new UserRole
                {
                    UserId = appAlice.Id,
                    RoleId = appBuyerRole.Id
                });
                appContext.Users.Add(appAlice);
                await appContext.SaveChangesAsync();
                await userMgr.AddToRoleAsync(alice, "Buyer");

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

        private static async Task<(IdentityRole<Guid>, IdentityRole<Guid>)> CreateRoles(
            RookEcomShopDbContext appContext,
            RoleManager<IdentityRole<Guid>> roleManager)
        {
            var adminRole = roleManager.FindByNameAsync("Admin").Result;
            if (adminRole == null)
            {
                adminRole = new IdentityRole<Guid>
                {
                    Name = "Admin",
                };
                _ = roleManager.CreateAsync(new IdentityRole<Guid>("Admin")).Result;
                _ = appContext.Roles.Add(new Role { Name = "Admin" });
            }

            var buyerRole = roleManager.FindByNameAsync("Buyer").Result;
            if (buyerRole == null)
            {
                buyerRole = new IdentityRole<Guid>
                {
                    Name = "Buyer",
                };
                _ = roleManager.CreateAsync(new IdentityRole<Guid>("Buyer")).Result;
                _ = appContext.Roles.Add(new Role { Name = "Buyer" });
            }
            await appContext.SaveChangesAsync();

            return (adminRole, buyerRole);
        }


        private static async Task CreateBobUser(RookEcomShopDbContext appContext, UserManager<ApplicationUser> userMgr, IdentityRole<Guid> adminRole)
        {
            try
            {
                var bob = await userMgr.FindByNameAsync("bob");
                var appBob = await appContext.Users.FirstOrDefaultAsync(u => u.FirstName == "Bob");
                if (bob == null && appBob == null)
                {
                    bob = new ApplicationUser
                    {
                        Id= Guid.NewGuid(),
                        FirstName = "Bob",
                        LastName = "Smith",
                        UserName = "bob",
                        Email = "BobSmith@email.com",
                        EmailConfirmed = true
                    };
                    appBob = new User
                    {
                        Id = bob.Id,
                        FirstName = bob.FirstName,
                        LastName = bob.LastName,
                        Email = bob.Email,
                        Username = bob.UserName,
                        EmailConfirmed = true,
                    };
                    var result = userMgr.CreateAsync(bob, "Pass123$").Result;
                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }
                    var appAdminRole = await appContext.Roles.FirstOrDefaultAsync(r => r.Name == "Admin");
                    appBob.UserRoles.Add(new UserRole
                    {
                        UserId = appBob.Id,
                        RoleId = appAdminRole.Id
                    });
                    appContext.Users.Add(appBob);
                    await appContext.SaveChangesAsync();

                    await userMgr.AddToRoleAsync(bob, "Admin");

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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
#nullable enable

using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Entities;
using RookEcomShop.IdentityServer.Domain;
using RookEcomShop.IdentityServer.Persistence;
using RookEcomShop.Persistence;
using Serilog;
using System.Security.Claims;

namespace RookEcomShop.IdentityServer.Configuration
{
    public class SeedUsers
    {
        public static async Task EnsureSeedData(string connectionString, string rookEcomConnection)
        {
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddDbContext<IdentityServerDbContext>(options => options.UseSqlServer(connectionString));
            services.AddDbContext<RookEcomShopDbContext>(options => options.UseSqlServer(rookEcomConnection));
            services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<IdentityServerDbContext>()
                .AddDefaultTokenProviders();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                using (var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    try
                    {
                        var identityContext = scope.ServiceProvider.GetService<IdentityServerDbContext>();
                        var appContext = scope.ServiceProvider.GetService<RookEcomShopDbContext>();

                        if (identityContext == null || appContext == null)
                        {
                            Log.Error("Database context is null");
                            throw new Exception("Database context is null");
                        }

                        await identityContext.Database.MigrateAsync();
                        await appContext.Database.MigrateAsync();

                        var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                        var roleMgr = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

                        if (userMgr == null || roleMgr == null)
                        {
                            Log.Error("UserManager or RoleManager is null");
                            throw new Exception("UserManager or RoleManager is null");
                        }

                        var roles = await CreateRolesAsync(appContext, roleMgr);
                        await CreateUserAsync(appContext, userMgr, "alice", "Alice", "Smith", "AliceSmith@email.com", "Pass123$", roles.BuyerRole, new Claim[]
                        {
                            new Claim(JwtClaimTypes.Name, "Alice Smith"),
                            new Claim(JwtClaimTypes.GivenName, "Alice"),
                            new Claim(JwtClaimTypes.FamilyName, "Smith"),
                            new Claim(JwtClaimTypes.WebSite, "http://alice.com")
                        });

                        await CreateUserAsync(appContext, userMgr, "bob", "Bob", "Smith", "BobSmith@email.com", "Pass123$", roles.AdminRole, new Claim[]
                        {
                            new Claim(JwtClaimTypes.Name, "Bob Smith"),
                            new Claim(JwtClaimTypes.GivenName, "Bob"),
                            new Claim(JwtClaimTypes.FamilyName, "Smith"),
                            new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                            new Claim("location", "somewhere"),
                            new Claim(JwtClaimTypes.Role, "Admin")
                        });
                    }
                    catch (Exception e)
                    {
                        Log.Error(e, "An error occurred while seeding the database.");
                        throw;
                    }
                }
            }
        }

        private static async Task<(IdentityRole<Guid> AdminRole, IdentityRole<Guid> BuyerRole)> CreateRolesAsync(RookEcomShopDbContext appContext, RoleManager<IdentityRole<Guid>> roleMgr)
        {
            var adminRole = await EnsureRoleAsync(appContext, roleMgr, "Admin");
            var buyerRole = await EnsureRoleAsync(appContext, roleMgr, "Buyer");
            await appContext.SaveChangesAsync();
            return (adminRole, buyerRole);
        }

        private static async Task<IdentityRole<Guid>> EnsureRoleAsync(RookEcomShopDbContext appContext, RoleManager<IdentityRole<Guid>> roleMgr, string roleName)
        {
            var role = await roleMgr.FindByNameAsync(roleName);
            if (role == null)
            {
                role = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = roleName };
                await roleMgr.CreateAsync(role);
                appContext.Roles.Add(new Role { Id = role.Id, Name = roleName });
            }
            return role;
        }

        private static async Task CreateUserAsync(
            RookEcomShopDbContext appContext,
            UserManager<ApplicationUser> userMgr,
            string username,
            string firstName,
            string lastName,
            string email,
            string password,
            IdentityRole<Guid> role,
            Claim[] claims)
        {
            var user = await userMgr.FindByNameAsync(username);
            var appUser = await appContext.Users.FirstOrDefaultAsync(u => u.FirstName == firstName);

            if (user == null && appUser == null)
            {
                user = new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    FirstName = firstName,
                    LastName = lastName,
                    UserName = username,
                    Email = email,
                    EmailConfirmed = true
                };

                var createResult = await userMgr.CreateAsync(user, password);
                if (!createResult.Succeeded)
                {
                    throw new Exception(createResult.Errors.First().Description);
                }

                appUser = new User
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Username = user.UserName,
                    EmailConfirmed = user.EmailConfirmed,
                    UserRoles = new List<UserRole> { new UserRole { UserId = user.Id, RoleId = role.Id } }
                };

                appContext.Users.Add(appUser);
                await appContext.SaveChangesAsync();

                await userMgr.AddToRoleAsync(user, role.Name!);
                var claimResult = await userMgr.AddClaimsAsync(user, claims);
                if (!claimResult.Succeeded)
                {
                    throw new Exception(claimResult.Errors.First().Description);
                }

                Log.Debug($"{username} created");
            }
            else
            {
                Log.Debug($"{username} already exists");
            }

            if (user != null && !await userMgr.IsInRoleAsync(user, role.Name!))
            {
                await userMgr.AddToRoleAsync(user, role.Name);
            }
        }
    }
}

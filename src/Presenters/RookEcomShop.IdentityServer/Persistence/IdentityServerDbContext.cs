using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.IdentityServer.Domain;

namespace RookEcomShop.IdentityServer.Persistence
{
    public class IdentityServerDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public IdentityServerDbContext()
        {

        }

        public IdentityServerDbContext(DbContextOptions<IdentityServerDbContext> options) : base(options)
        {

        }
    }
}

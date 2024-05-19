
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Infrastructure.Extensions;

namespace RookEcomShop.Infrastructure.Persistence
{
    public partial class RookEcomShopDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public RookEcomShopDbContext()
        {
        }

        public RookEcomShopDbContext(DbContextOptions<RookEcomShopDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }

        public virtual DbSet<CartDetail> CartDetails { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }

        public virtual DbSet<Review> Reviews { get; set; }

        public virtual DbSet<PaymentTransaction> PaymentTransactions { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RookEcomShopDbContext).Assembly);
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder
        .LogTo(Console.WriteLine)
        .EnableDetailedErrors();
    }
}

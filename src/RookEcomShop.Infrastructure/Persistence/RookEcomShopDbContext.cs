
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Infrastructure.Persistence
{
    public partial class RookEcomShopDbContext : DbContext
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

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RookEcomShopDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}

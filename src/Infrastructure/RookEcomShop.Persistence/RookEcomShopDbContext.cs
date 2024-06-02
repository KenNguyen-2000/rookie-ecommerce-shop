using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Data;
using RookEcomShop.Domain.Common;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Persistence.DataSeeding;

namespace RookEcomShop.Persistence;

public partial class RookEcomShopDbContext : DbContext, IRookEcomShopDbContext
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
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RookEcomShopDbContext).Assembly);
        modelBuilder.Seed();
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
=> optionsBuilder
    .LogTo(Console.WriteLine)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors();

    public override int SaveChanges()
    {
        SetTimestamps();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        SetTimestamps();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void SetTimestamps()
    {
        var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is BaseEntity<Guid> &&
                        (e.State == EntityState.Added || e.State == EntityState.Modified));

        foreach (var entry in entries)
        {
            var entity = (BaseEntity<Guid>)entry.Entity;
            if (entry.State == EntityState.Added)
            {
                entity.CreatedAt = DateTime.UtcNow;
            }
            entity.UpdatedAt = DateTime.UtcNow;
        }
    }
}
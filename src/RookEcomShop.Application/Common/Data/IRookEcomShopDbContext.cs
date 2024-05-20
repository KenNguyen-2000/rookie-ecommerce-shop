using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Common.Data
{
    public interface IRookEcomShopDbContext
    {
        DbSet<Cart> Carts { get; set; }

        DbSet<CartDetail> CartDetails { get; set; }

        DbSet<Category> Categories { get; set; }

        DbSet<Order> Orders { get; set; }

        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<PaymentMethod> PaymentMethods { get; set; }

        DbSet<Product> Products { get; set; }
        DbSet<ProductImage> ProductImages { get; set; }

        DbSet<Review> Reviews { get; set; }

        DbSet<PaymentTransaction> PaymentTransactions { get; set; }
    }
}
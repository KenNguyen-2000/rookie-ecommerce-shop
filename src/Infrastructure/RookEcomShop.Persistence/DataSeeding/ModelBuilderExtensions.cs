using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Persistence.DataSeeding
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            CategoriesSeeder(modelBuilder.Entity<Category>());
            ProductSeeder.Seeder(modelBuilder.Entity<Product>());
        }

        private static class ProductSeeder
        {
            private static readonly Random Random = new Random();
            private static readonly string[] ProductNames = { "Widget", "Gadget", "Device", "Item", "Thing" };
            private static readonly string[] ProductDescriptions = { "High quality", "Brand new", "Best seller", "Limited edition", "Popular" };
            private static readonly decimal[] ProductPrices = { 19.99m, 29.99m, 49.99m, 99.99m, 149.99m };
            private static readonly int[] StockQuantities = { 10, 20, 50, 100, 200 };
            private static readonly ProductStatus[] ProductStatuses = { ProductStatus.Active, ProductStatus.Inactive };

            public static void Seeder(EntityTypeBuilder<Product> builder)
            {
                builder.ToTable(nameof(Product) + "s");
                var products = new List<Product>();
                var createdAt = DateTime.Now.AddMonths(-3);

                for (int i = 1; i <= 100; i++)
                {
                    var product = new Product
                    {
                        Id = i,
                        Name = GenerateProductName(),
                        Description = GenerateProductDescription(),
                        Price = GenerateProductPrice(),
                        StockQuantity = GenerateStockQuantity(),
                        Status = GenerateProductStatus(),
                        CreatedAt = createdAt,
                        UpdatedAt = createdAt.AddMonths(Random.Next(0, 3)),
                        CategoryId = GenerateCategoryId(),
                        UserId = 2
                    };

                    products.Add(product);
                }

                builder.HasData(products);

            }

            private static string GenerateProductName()
            {
                return $"{ProductNames[Random.Next(ProductNames.Length)]} {Random.Next(1000, 9999)}";
            }

            private static string GenerateProductDescription()
            {
                return ProductDescriptions[Random.Next(ProductDescriptions.Length)];
            }

            private static decimal GenerateProductPrice()
            {
                return ProductPrices[Random.Next(ProductPrices.Length)];
            }

            private static int GenerateStockQuantity()
            {
                return StockQuantities[Random.Next(StockQuantities.Length)];
            }

            private static ProductStatus GenerateProductStatus()
            {
                return ProductStatuses[Random.Next(ProductStatuses.Length)];
            }

            private static int GenerateUserId()
            {
                return Random.Next(1, 50); // Assuming there are 50 users
            }

            private static int GenerateCategoryId()
            {
                return Random.Next(2, 13);
            }
        }

        private static void CategoriesSeeder(EntityTypeBuilder<Category> modelBuilder)
        {
            // Seeding first level categories
            modelBuilder.HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Clothing" },
                new Category { Id = 3, Name = "Home & Kitchen" },
                new Category { Id = 4, Name = "Books" },
                new Category { Id = 5, Name = "Sports & Outdoors" },
                new Category { Id = 6, Name = "Beauty & Personal Care" },
                new Category { Id = 7, Name = "Health & Wellness" },
                new Category { Id = 8, Name = "Toys & Games" },
                new Category { Id = 9, Name = "Automotive" },
                new Category { Id = 10, Name = "Jewelry & Accessories" },
                new Category { Id = 11, Name = "Baby & Kids" },
                new Category { Id = 12, Name = "Grocery & Gourmet" }
            );

            // Seeding second level categories
            modelBuilder.HasData(
                // Electronics
                new Category { Id = 16, Name = "Smartphones", CategoryId = 1 },
                new Category { Id = 17, Name = "Laptops", CategoryId = 1 },
                new Category { Id = 18, Name = "Tablets", CategoryId = 1 },

                // Clothing
                new Category { Id = 13, Name = "Furniture", CategoryId = 3 },
                new Category { Id = 14, Name = "Appliances", CategoryId = 3 },
                new Category { Id = 15, Name = "Decor", CategoryId = 3 },

                // Books
                new Category { Id = 19, Name = "Fiction", CategoryId = 4 },
                new Category { Id = 20, Name = "Non-Fiction", CategoryId = 4 }
            );
        }
    }
}

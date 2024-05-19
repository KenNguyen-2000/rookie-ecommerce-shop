using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Infrastructure.Persistence.DataSeeders
{
    public class ProductSeeder
    {

        private static readonly Random Random = new Random();
        private static readonly string[] ProductNames = { "Widget", "Gadget", "Device", "Item", "Thing" };
        private static readonly string[] ProductDescriptions = { "High quality", "Brand new", "Best seller", "Limited edition", "Popular" };
        private static readonly decimal[] ProductPrices = { 19.99m, 29.99m, 49.99m, 99.99m, 149.99m };
        private static readonly int[] StockQuantities = { 10, 20, 50, 100, 200 };
        private static readonly ProductStatus[] ProductStatuses = { ProductStatus.Active, ProductStatus.Inactive };

        public static void Seed(ModelBuilder modelBuilder)
        {
            var products = new List<Product>();
            var createdAt = DateTime.Now.AddMonths(-3);

            for (int i = 13; i <= 110; i++)
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

            modelBuilder.Entity<Product>().HasData(products);
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

}
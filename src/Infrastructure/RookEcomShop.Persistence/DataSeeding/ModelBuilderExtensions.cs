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

                var categoryIds = new List<Guid>
                {
                    new Guid("a1111111-1111-1111-1111-111111111111"), // Essentials
                    new Guid("a2222222-2222-2222-2222-222222222222"), // Household
                    new Guid("a3333333-3333-3333-3333-333333333333"), // Hair Care
                    new Guid("a4444444-4444-4444-4444-444444444444"), // Oral Hygiene
                    new Guid("a5555555-5555-5555-5555-555555555555"), // Clean Beauty
                    new Guid("a6666666-6666-6666-6666-666666666666"), // Bath & Body
                    new Guid("a7777777-7777-7777-7777-777777777777")  // Personal Hygiene
                };

                for (int i = 1; i <= 100; i++)
                {
                    var product = new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = GenerateProductName(),
                        Description = GenerateProductDescription(),
                        Price = GenerateProductPrice(),
                        StockQuantity = GenerateStockQuantity(),
                        Status = GenerateProductStatus(),
                        CreatedAt = createdAt,
                        UpdatedAt = createdAt.AddMonths(Random.Next(0, 3)),
                        CategoryId = categoryIds[Random.Next(categoryIds.Count)] // Assign random CategoryId from predefined list
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
            var essentialsId = new Guid("a1111111-1111-1111-1111-111111111111");
            var householdId = new Guid("a2222222-2222-2222-2222-222222222222");
            var hairCareId = new Guid("a3333333-3333-3333-3333-333333333333");
            var oralHygieneId = new Guid("a4444444-4444-4444-4444-444444444444");
            var cleanBeautyId = new Guid("a5555555-5555-5555-5555-555555555555");
            var bathBodyId = new Guid("a6666666-6666-6666-6666-666666666666");
            var personalHygieneId = new Guid("a7777777-7777-7777-7777-777777777777");

            modelBuilder.HasData(
                new Category { Id = essentialsId, Name = "Essentials" },
                new Category { Id = householdId, Name = "Household" },
                new Category { Id = hairCareId, Name = "Hair Care" },
                new Category { Id = oralHygieneId, Name = "Oral Hygiene" },
                new Category { Id = cleanBeautyId, Name = "Clean Beauty" },
                new Category { Id = bathBodyId, Name = "Bath & Body" },
                new Category { Id = personalHygieneId, Name = "Personal Hygiene" }
            );

            modelBuilder.HasData(
                // Essentials
                new Category { Id = Guid.NewGuid(), Name = "Suds & Eco", CategoryId = essentialsId },
                new Category { Id = Guid.NewGuid(), Name = "ZWS Essentials", CategoryId = essentialsId },
                new Category { Id = Guid.NewGuid(), Name = "Endangered Tees", CategoryId = essentialsId },

                // Household
                new Category { Id = Guid.NewGuid(), Name = "Kitchen", CategoryId = householdId },
                new Category { Id = Guid.NewGuid(), Name = "Cleaning", CategoryId = householdId },
                new Category { Id = Guid.NewGuid(), Name = "Dish Brushes", CategoryId = householdId },
                new Category { Id = Guid.NewGuid(), Name = "Composing", CategoryId = householdId },
                new Category { Id = Guid.NewGuid(), Name = "Laundry Detergent", CategoryId = householdId },
                new Category { Id = Guid.NewGuid(), Name = "Pet Care", CategoryId = householdId },
                new Category { Id = Guid.NewGuid(), Name = "Beding & Bath", CategoryId = householdId },
                new Category { Id = Guid.NewGuid(), Name = "Kids & Baby", CategoryId = householdId },
                new Category { Id = Guid.NewGuid(), Name = "Tech", CategoryId = householdId },

                // Hair Care
                new Category { Id = Guid.NewGuid(), Name = "Shampoo Bar", CategoryId = hairCareId },
                new Category { Id = Guid.NewGuid(), Name = "Conditioner Bar", CategoryId = hairCareId },
                new Category { Id = Guid.NewGuid(), Name = "Bamboo Hair Brush", CategoryId = hairCareId },

                // Oral Hygiene
                new Category { Id = Guid.NewGuid(), Name = "Bamboo Toothbrush", CategoryId = oralHygieneId },
                new Category { Id = Guid.NewGuid(), Name = "Dental Floss", CategoryId = oralHygieneId },
                new Category { Id = Guid.NewGuid(), Name = "Toothpaste", CategoryId = oralHygieneId },

                // Clean Beauty
                new Category { Id = Guid.NewGuid(), Name = "Makeup", CategoryId = cleanBeautyId },
                new Category { Id = Guid.NewGuid(), Name = "Skin Care", CategoryId = cleanBeautyId },
                new Category { Id = Guid.NewGuid(), Name = "Soap Bars", CategoryId = cleanBeautyId },

                // Personal Hygiene
                new Category { Id = Guid.NewGuid(), Name = "Period Care", CategoryId = personalHygieneId },
                new Category { Id = Guid.NewGuid(), Name = "Deodorant", CategoryId = personalHygieneId },
                new Category { Id = Guid.NewGuid(), Name = "Shaving", CategoryId = personalHygieneId }
            );
        }
    
        
    }
}

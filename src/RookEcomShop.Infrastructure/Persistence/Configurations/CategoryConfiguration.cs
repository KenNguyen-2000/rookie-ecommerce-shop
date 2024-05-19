using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Infrastructure.Persistence.Configurations
{
    public sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Name).IsUnique();

            builder.HasData(
     new Category
     {
         Id = 13,
         Name = "Electronics",
         SubCategories = new List<Category>
     {
        new() { Id = 14, Name = "Mobile Phones" },
        new() { Id = 15, Name = "Computers & Tablets" },
        new() { Id = 16, Name = "TV & Home Theater" }
     }
     },
     new Category
     {
         Id = 2,
         Name = "Clothing",
         SubCategories = new List<Category>
     {
        new() { Id = 17, Name = "Men's Clothing" },
        new() { Id = 18, Name = "Women's Clothing" },
        new() { Id = 19, Name = "Kid's Clothing" }
     }
     },
     new Category
     {
         Id = 3,
         Name = "Home & Kitchen",
         SubCategories = new List<Category>
     {
        new() { Id = 20, Name = "Furniture" },
        new() { Id = 21, Name = "Kitchen Appliances" },
        new() { Id = 22, Name = "Bedding" }
     }
     },
     new Category
     {
         Id = 4,
         Name = "Books",
         SubCategories = new List<Category>
     {
        new() { Id = 23, Name = "Fiction" },
        new() { Id = 24, Name = "Non-Fiction" },
        new() { Id = 25, Name = "Children's Books" }
     }
     },
     new Category
     {
         Id = 5,
         Name = "Sports & Outdoors",
         SubCategories = new List<Category>
     {
        new() { Id = 26, Name = "Exercise & Fitness" },
        new() { Id = 27, Name = "Outdoor Recreation" },
        new() { Id = 28, Name = "Team Sports" }
     }
     },
     new Category
     {
         Id = 6,
         Name = "Beauty & Personal Care",
         SubCategories = new List<Category>
     {
        new() { Id = 29, Name = "Skin Care" },
        new() { Id = 30, Name = "Hair Care" },
        new() { Id = 31, Name = "Makeup" }
     }
     },
     new Category
     {
         Id = 7,
         Name = "Health & Wellness",
         SubCategories = new List<Category>
     {
        new() { Id = 32, Name = "Supplements" },
        new() { Id = 33, Name = "Medical Supplies" },
        new() { Id = 34, Name = "Personal Care" }
     }
     },
     new Category
     {
         Id = 8,
         Name = "Toys & Games",
         SubCategories = new List<Category>
     {
        new() { Id = 35, Name = "Action Figures" },
        new() { Id = 36, Name = "Board Games" },
        new() { Id = 37, Name = "Puzzles" }
     }
     },
     new Category
     {
         Id = 9,
         Name = "Automotive",
         SubCategories = new List<Category>
     {
        new() { Id = 38, Name = "Car Accessories" },
        new() { Id = 39, Name = "Car Electronics" },
        new() { Id = 40, Name = "Motorcycle Parts" }
     }
     },
     new Category
     {
         Id = 10,
         Name = "Jewelry & Accessories",
         SubCategories = new List<Category>
     {
        new() { Id = 41, Name = "Men's Jewelry" },
        new() { Id = 42, Name = "Women's Jewelry" },
        new() { Id = 43, Name = "Watches" }
     }
     },
     new Category
     {
         Id = 11,
         Name = "Baby & Kids",
         SubCategories = new List<Category>
     {
        new() { Id = 44, Name = "Baby Gear" },
        new() { Id = 45, Name = "Nursery Furniture" },
        new() { Id = 46, Name = "Kid's Toys" }
     }
     },
     new Category
     {
         Id = 12,
         Name = "Grocery & Gourmet",
         SubCategories = new List<Category>
     {
        new() { Id = 47, Name = "Snacks" },
        new() { Id = 48, Name = "Beverages" },
        new() { Id = 49, Name = "Cooking Ingredients" }
     }
     }
 );
        }
    }
}

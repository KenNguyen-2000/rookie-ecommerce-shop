using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RookEcomShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoryId",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, null, "Electronics" },
                    { 2, null, null, "Clothing" },
                    { 3, null, null, "Home & Kitchen" },
                    { 4, null, null, "Books" },
                    { 5, null, null, "Sports & Outdoors" },
                    { 6, null, null, "Beauty & Personal Care" },
                    { 7, null, null, "Health & Wellness" },
                    { 8, null, null, "Toys & Games" },
                    { 9, null, null, "Automotive" },
                    { 10, null, null, "Jewelry & Accessories" },
                    { 11, null, null, "Baby & Kids" },
                    { 12, null, null, "Grocery & Gourmet" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 6648", 49.99m, 0, 50, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 2, 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Widget 5500", 149.99m, 0, 200, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 3, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 2523", 19.99m, 0, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 4, 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Device 9301", 29.99m, 0, 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 5, 6, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Device 1348", 29.99m, 0, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 6, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Item 2601", 149.99m, 1, 50, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 7, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Gadget 3794", 49.99m, 0, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 8, 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Widget 6745", 149.99m, 0, 200, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 9, 6, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Widget 8858", 19.99m, 0, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 10, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Item 5631", 29.99m, 1, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 11, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Thing 9782", 29.99m, 1, 50, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 12, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Thing 7725", 149.99m, 1, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 13, 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Thing 4473", 49.99m, 0, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 14, 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Item 3408", 49.99m, 1, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 15, 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Item 1616", 29.99m, 0, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 16, 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Item 8358", 149.99m, 1, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 17, 6, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Thing 7846", 49.99m, 1, 20, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 18, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Thing 8825", 29.99m, 1, 20, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 19, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 1849", 29.99m, 0, 200, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 20, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Item 3997", 29.99m, 1, 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 21, 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Item 2487", 99.99m, 1, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 22, 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 4115", 19.99m, 0, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 23, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Item 8958", 149.99m, 0, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 24, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Device 6346", 149.99m, 1, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 25, 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 3463", 19.99m, 0, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 26, 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Device 1518", 149.99m, 1, 20, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 27, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Widget 8840", 49.99m, 0, 20, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 28, 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Gadget 9894", 99.99m, 0, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 29, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 2414", 149.99m, 1, 100, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 30, 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Thing 8058", 99.99m, 0, 20, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 31, 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Device 1251", 19.99m, 0, 20, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 32, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Gadget 9801", 49.99m, 0, 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 33, 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Widget 9023", 49.99m, 1, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 34, 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Device 9722", 149.99m, 0, 200, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 35, 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Device 2563", 19.99m, 1, 200, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 36, 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Gadget 9524", 49.99m, 1, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 37, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 5993", 149.99m, 0, 100, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 38, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Thing 5041", 99.99m, 0, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 39, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Gadget 3512", 49.99m, 1, 50, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 40, 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Device 5270", 149.99m, 1, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 41, 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 4581", 149.99m, 1, 100, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 42, 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Widget 3182", 149.99m, 1, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 43, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Widget 2332", 99.99m, 1, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 44, 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Device 3590", 29.99m, 1, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 45, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Widget 3888", 99.99m, 1, 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 46, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Item 7824", 49.99m, 0, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 47, 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 4106", 49.99m, 1, 200, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 48, 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Gadget 9461", 29.99m, 1, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 49, 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 4830", 29.99m, 1, 100, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 50, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 3219", 99.99m, 1, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 51, 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Thing 2457", 49.99m, 1, 50, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 52, 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Widget 2553", 49.99m, 0, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 53, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 2679", 149.99m, 0, 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 54, 6, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Gadget 9107", 29.99m, 0, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 55, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 2880", 99.99m, 1, 200, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 56, 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Widget 7673", 29.99m, 1, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 57, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 4211", 99.99m, 0, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 58, 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Widget 3345", 29.99m, 1, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 59, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Thing 8433", 19.99m, 0, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 60, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Item 2371", 49.99m, 0, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 61, 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 7732", 49.99m, 0, 200, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 62, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Widget 3266", 99.99m, 0, 20, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 63, 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Thing 3902", 19.99m, 1, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 64, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Device 6895", 29.99m, 1, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 65, 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Thing 1154", 29.99m, 1, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 66, 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 2976", 149.99m, 1, 200, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 67, 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 2256", 99.99m, 0, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 68, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Gadget 5245", 29.99m, 0, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 69, 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Thing 4085", 99.99m, 0, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 70, 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Thing 6138", 99.99m, 0, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 71, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Widget 7661", 99.99m, 1, 200, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 72, 6, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Widget 2355", 19.99m, 1, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 73, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Item 1935", 29.99m, 0, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 74, 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Device 1033", 49.99m, 0, 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 75, 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Item 4708", 99.99m, 0, 20, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 76, 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Widget 3152", 19.99m, 0, 200, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 77, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Device 5381", 99.99m, 1, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 78, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Gadget 4793", 29.99m, 1, 20, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 79, 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Gadget 6093", 19.99m, 1, 100, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 80, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 3499", 29.99m, 1, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 81, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Device 9616", 19.99m, 0, 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 82, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Item 9721", 149.99m, 1, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 83, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Thing 9424", 29.99m, 0, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 84, 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Thing 5528", 99.99m, 0, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 85, 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Thing 4052", 19.99m, 0, 20, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 86, 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Widget 8456", 149.99m, 0, 100, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 87, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Device 9825", 149.99m, 1, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 88, 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Device 2031", 29.99m, 0, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 89, 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Widget 6355", 19.99m, 1, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 90, 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Gadget 1454", 49.99m, 1, 100, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 91, 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Item 8672", 49.99m, 1, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 92, 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Widget 7024", 99.99m, 1, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 93, 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 4960", 29.99m, 1, 100, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 94, 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 2862", 49.99m, 0, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 95, 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Device 8024", 99.99m, 0, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 96, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 7878", 29.99m, 0, 100, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 97, 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Device 6136", 49.99m, 1, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 98, 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Widget 9115", 149.99m, 0, 100, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 99, 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Gadget 1858", 49.99m, 1, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 },
                    { 100, 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Widget 9593", 19.99m, 0, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoryId",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}

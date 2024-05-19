using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RookEcomShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDataSeedingForCategoriesAndProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
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
                    { 12, null, null, "Grocery & Gourmet" },
                    { 13, null, null, "Electronics" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 22, 1, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Item 2326", 49.99m, 1, 200, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 29, 1, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Item 7715", 149.99m, 1, 100, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 34, 1, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Gadget 4484", 49.99m, 0, 50, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 42, 1, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Widget 9451", 49.99m, 0, 100, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 52, 1, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Thing 5227", 29.99m, 0, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 68, 1, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Device 8354", 19.99m, 1, 100, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 77, 1, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Gadget 3743", 49.99m, 0, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 82, 1, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Widget 1174", 29.99m, 0, 50, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 92, 1, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Device 2282", 49.99m, 1, 20, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 13, 2, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Widget 1619", 49.99m, 1, 100, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 14, 12, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Item 6652", 149.99m, 0, 100, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 15, 12, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Device 7597", 99.99m, 0, 20, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 16, 12, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Item 1076", 29.99m, 0, 100, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 17, 3, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Item 6797", 99.99m, 1, 10, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 18, 12, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Gadget 3651", 99.99m, 0, 50, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 19, 7, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Item 9947", 149.99m, 1, 50, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 20, 8, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Item 2846", 149.99m, 1, 10, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 21, 3, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Item 2426", 99.99m, 1, 100, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 23, 9, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Thing 6572", 19.99m, 0, 20, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 24, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Thing 7842", 99.99m, 0, 20, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 25, 12, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Widget 3975", 99.99m, 0, 100, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 26, 11, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Thing 3789", 99.99m, 1, 100, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 27, 7, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Thing 9406", 99.99m, 1, 20, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 28, 5, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Item 4344", 49.99m, 0, 100, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 30, 2, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Gadget 4866", 49.99m, 0, 50, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 31, 8, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Widget 5705", 99.99m, 1, 20, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 32, 8, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Widget 6739", 49.99m, 0, 200, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 33, 7, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Gadget 4275", 99.99m, 0, 20, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 35, 7, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Widget 9806", 49.99m, 1, 200, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 36, 2, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Thing 4295", 99.99m, 0, 50, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 37, 11, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Device 4652", 99.99m, 0, 200, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 38, 4, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Gadget 5271", 149.99m, 1, 100, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 39, 6, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Widget 4560", 19.99m, 1, 200, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 40, 12, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Gadget 5491", 49.99m, 0, 20, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 41, 9, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Device 1944", 99.99m, 0, 20, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 43, 11, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Item 7472", 19.99m, 1, 100, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 44, 3, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Thing 9752", 149.99m, 0, 20, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 45, 8, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Widget 7726", 99.99m, 0, 20, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 46, 6, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Gadget 5479", 99.99m, 0, 200, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 47, 2, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Gadget 8828", 149.99m, 0, 20, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 48, 8, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Gadget 7258", 49.99m, 0, 50, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 49, 11, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Gadget 4898", 99.99m, 1, 100, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 50, 9, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Item 2258", 19.99m, 1, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 51, 3, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Device 6882", 49.99m, 1, 20, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 53, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Item 2375", 29.99m, 0, 20, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 54, 8, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Thing 3086", 29.99m, 1, 200, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 55, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Device 9027", 149.99m, 1, 20, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 56, 3, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Widget 5408", 19.99m, 0, 100, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 57, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Item 7275", 29.99m, 0, 10, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 58, 8, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Thing 5027", 99.99m, 0, 100, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 59, 11, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Device 5016", 29.99m, 0, 100, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 60, 5, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Device 1168", 149.99m, 0, 100, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 61, 9, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Widget 3199", 99.99m, 1, 100, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 62, 2, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Gadget 1578", 29.99m, 0, 50, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 63, 7, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Item 3074", 99.99m, 0, 200, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 64, 3, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Widget 4750", 19.99m, 0, 50, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 65, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Gadget 1232", 49.99m, 0, 200, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 66, 7, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Item 2217", 49.99m, 1, 200, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 67, 6, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Device 5306", 149.99m, 1, 50, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 69, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Thing 5682", 29.99m, 0, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 70, 9, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Item 4493", 29.99m, 0, 20, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 71, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Gadget 8188", 149.99m, 1, 200, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 72, 7, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Gadget 8637", 29.99m, 0, 10, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 73, 12, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Item 3287", 19.99m, 1, 20, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 74, 5, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Widget 8915", 19.99m, 0, 200, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 75, 8, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Widget 1026", 99.99m, 1, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 76, 9, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Device 8828", 49.99m, 1, 200, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 78, 3, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Device 7128", 29.99m, 0, 100, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 79, 9, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Device 2443", 99.99m, 1, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 80, 5, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Item 5594", 149.99m, 1, 10, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 81, 2, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Gadget 4231", 19.99m, 0, 50, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 83, 6, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Thing 5128", 49.99m, 1, 50, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 84, 2, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Widget 4690", 99.99m, 0, 20, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 85, 7, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Gadget 7187", 49.99m, 1, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 86, 3, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Gadget 7329", 149.99m, 1, 10, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 87, 6, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Item 9728", 29.99m, 0, 100, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 88, 2, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Gadget 8180", 29.99m, 0, 20, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 89, 5, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Device 6141", 49.99m, 1, 10, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 90, 4, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Gadget 4866", 99.99m, 1, 10, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 91, 5, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Widget 8142", 149.99m, 1, 50, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 93, 12, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Gadget 8215", 99.99m, 1, 10, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 94, 4, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Device 7293", 149.99m, 0, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 95, 2, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Item 6111", 149.99m, 1, 50, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 96, 12, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Thing 6053", 19.99m, 1, 50, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 97, 11, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Widget 8931", 49.99m, 0, 50, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 98, 3, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Widget 5135", 99.99m, 1, 20, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 99, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Thing 8641", 149.99m, 0, 200, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 100, 12, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Brand new", "Gadget 2874", 99.99m, 1, 200, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 101, 3, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Gadget 7120", 99.99m, 1, 50, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 102, 6, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Widget 2593", 49.99m, 1, 100, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 103, 3, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Device 8922", 99.99m, 0, 50, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 104, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Device 1039", 29.99m, 0, 20, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 105, 12, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Device 4671", 49.99m, 1, 100, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 106, 11, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Best seller", "Thing 5061", 19.99m, 1, 100, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 107, 11, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "High quality", "Thing 4497", 29.99m, 0, 100, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 108, 11, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Device 6473", 99.99m, 0, 50, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 109, 9, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Limited edition", "Widget 8449", 19.99m, 1, 200, new DateTime(2024, 4, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 },
                    { 110, 10, new DateTime(2024, 2, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), "Popular", "Item 4310", 49.99m, 1, 10, new DateTime(2024, 3, 19, 13, 27, 38, 885, DateTimeKind.Local).AddTicks(537), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

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
        }
    }
}

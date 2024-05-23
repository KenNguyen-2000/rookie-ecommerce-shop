using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RookEcomShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 13, 3, null, "Furniture" },
                    { 14, 3, null, "Appliances" },
                    { 15, 3, null, "Decor" },
                    { 16, 1, null, "Smartphones" },
                    { 17, 1, null, "Laptops" },
                    { 18, 1, null, "Tablets" },
                    { 19, 4, null, "Fiction" },
                    { 20, 4, null, "Non-Fiction" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Gadget 2581", 49.99m, 1, 100, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Device 1485", 149.99m, 1, 20, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Device 8775", 49.99m, 1, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Item 2881", 49.99m, 1, 100, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Device 8631", 149.99m, 200, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Item 5211", 200, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Item 6642", 49.99m, 0, 50, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Widget 5619", 29.99m, 1, 200, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Item 7388", 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Thing 8881", 49.99m, 100, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Widget 4170", 19.99m, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Thing 1089", 99.99m, 200, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Item 8070", 50, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Item 6602", 0, 50, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Item 3242", 99.99m, 10, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Device 9242", 1, 100, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Device 3452", 49.99m, 0, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Item 7388", 19.99m, 0, 10, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Item 4202", 29.99m, 50, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Device 4060", new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Thing 7316", 99.99m, 50, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Gadget 9413", 49.99m, 0, 200, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Device 9084", 1, 100, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Thing 2851", 99.99m, 0, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Item 1097", 49.99m, 1, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Widget 9414", 0, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Widget 1079", 149.99m, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Thing 2624", 19.99m, 10, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Widget 4420", 19.99m, 200, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Device 8812", 49.99m, 1, 100, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Gadget 5548", 149.99m, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Device 8895", 29.99m, 1, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Device 8760", 99.99m, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Item 1747", 149.99m, 1, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Widget 1537", 19.99m, 0, 10, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Widget 5722", 29.99m, 100, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Thing 6214", 19.99m, 0, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Gadget 2441", 149.99m, 200, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Gadget 1743", 149.99m, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Device 9229", 149.99m, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Item 2537", 99.99m, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Device 2312", 99.99m, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Device 4772", 99.99m, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Thing 8918", 19.99m, 1, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Widget 8261", 19.99m, 100, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Gadget 5210", 99.99m, 20, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Item 8801", 1, 20, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Gadget 3045", 149.99m, 0, 50, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Widget 5054", 19.99m, 100, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Thing 8876", 99.99m, 1, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Gadget 7124", 49.99m, 1, 50, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Item 3209", 49.99m, 0, 10, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Thing 9055", 99.99m, 200, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Gadget 6108", 1, 100, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Gadget 1222", 100, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Device 4223", 149.99m, 0, 100, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Widget 2404", 99.99m, 50, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Thing 7194", 149.99m, 100, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Device 1628", 49.99m, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Widget 8220", 50, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Item 3249", 149.99m, 20, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Device 2500", 149.99m, 1, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Widget 7030", 99.99m, 0, 100, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Item 4928", 19.99m, 1, 10, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Device 5110", 49.99m, 0, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Thing 7345", 49.99m, 0, 20, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Gadget 9516", 99.99m, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Item 4073", 0, 50, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Widget 9026", 29.99m, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Gadget 6082", 49.99m, 0, 20, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Item 7510", 1, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Thing 9589", 1, 50, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Device 6617", 99.99m, 1, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Item 5537", 200, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Item 9008", 99.99m, 0, 100, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Widget 2566", 29.99m, 1, 100, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Thing 6805", 0, 100, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Thing 1135", 49.99m, 0, 100, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Gadget 7269", 49.99m, 100, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Item 5906", 149.99m, 1, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Device 1709", 19.99m, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Thing 5426", 149.99m, 50, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Item 3727", 49.99m, 0, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Gadget 6696", 19.99m, 1, 50, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Item 5291", 1, 200, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Gadget 2871", 19.99m, 50, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Widget 9541", 29.99m, 1, 100, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Item 5263", 20, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Thing 6606", 149.99m, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Popular", "Gadget 5590", 29.99m, 0, 50, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Widget 5934", 149.99m, 1, 200, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Thing 7181", 49.99m, 50, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Item 2395", 29.99m, 200, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "High quality", "Gadget 3174", 29.99m, 1, 200, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Item 6346", 149.99m, 100, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Limited edition", "Gadget 5179", 99.99m, 20, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Brand new", "Gadget 7581", 1, 50, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Widget 9382", 149.99m, 1, 10, new DateTime(2024, 4, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Item 7260", 0, 100, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352), "Best seller", "Device 5320", 19.99m, 0, 20, new DateTime(2024, 3, 23, 9, 43, 44, 508, DateTimeKind.Local).AddTicks(7352) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Gadget 6519", 99.99m, 0, 20, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Item 7147", 49.99m, 0, 100, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Widget 8142", 99.99m, 0, 200, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Gadget 6641", 99.99m, 0, 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Gadget 5805", 49.99m, 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Device 5473", 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Widget 5692", 99.99m, 1, 20, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Device 8425", 149.99m, 0, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Widget 5324", 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Item 2595", 19.99m, 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Gadget 1014", 99.99m, 50, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 3551", 149.99m, 100, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Item 4222", 20, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Device 3657", 1, 10, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Thing 9526", 29.99m, 50, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Item 4400", 0, 200, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Gadget 2281", 19.99m, 1, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Gadget 7595", 99.99m, 1, 200, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Item 9490", 99.99m, 100, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Item 6682", new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Thing 5427", 49.99m, 20, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 3549", 29.99m, 1, 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Gadget 7436", 0, 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Item 9274", 29.99m, 1, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Device 2379", 19.99m, 0, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Widget 1121", 1, 200, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 6370", 29.99m, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Thing 8444", 99.99m, 20, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Gadget 6911", 99.99m, 100, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Widget 4839", 19.99m, 0, 200, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Gadget 6011", 19.99m, 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Item 3787", 49.99m, 0, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Widget 4189", 49.99m, 10, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Thing 8051", 19.99m, 0, 200, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 6459", 99.99m, 1, 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Gadget 4362", 19.99m, 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 8691", 149.99m, 1, 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 9818", 29.99m, 100, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Device 5513", 99.99m, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Device 5079", 29.99m, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Thing 5069", 149.99m, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Widget 6143", 19.99m, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Thing 7102", 19.99m, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Item 1222", 149.99m, 0, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Device 6606", 99.99m, 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Device 4629", 149.99m, 100, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Item 6227", 0, 50, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Thing 3522", 49.99m, 1, 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Gadget 8713", 29.99m, 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Item 5916", 149.99m, 0, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Thing 7958", 19.99m, 0, 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Item 1957", 99.99m, 1, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Item 3411", 149.99m, 20, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Device 3778", 0, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Widget 3489", 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Gadget 7197", 19.99m, 1, 50, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Device 1308", 49.99m, 100, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Widget 6426", 29.99m, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Widget 9383", 99.99m, 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Widget 5166", 10, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Widget 6997", 29.99m, 100, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Gadget 5353", 99.99m, 0, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Item 1526", 29.99m, 1, 10, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Device 6162", 99.99m, 0, 200, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Item 7768", 99.99m, 1, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Thing 6381", 99.99m, 1, 100, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 9705", 29.99m, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Item 8941", 1, 20, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Widget 3006", 99.99m, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Item 2560", 19.99m, 1, 100, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 4318", 0, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Gadget 2229", 0, 20, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 9238", 29.99m, 0, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 9793", 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Item 1319", 49.99m, 1, 50, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Thing 8277", 99.99m, 0, 200, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Gadget 6798", 1, 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Item 8820", 29.99m, 1, 20, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Device 4440", 19.99m, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Thing 9130", 19.99m, 0, 100, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Device 4956", 49.99m, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Gadget 9430", 19.99m, 100, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Widget 7161", 19.99m, 1, 100, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Thing 8947", 49.99m, 0, 100, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Thing 6996", 0, 20, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Thing 5617", 49.99m, 20, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Widget 2175", 99.99m, 0, 20, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Thing 8144", 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Thing 6186", 29.99m, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 3093", 49.99m, 1, 10, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 2297", 49.99m, 0, 100, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Device 8465", 29.99m, 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 7358", 19.99m, 100, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 3719", 49.99m, 0, 10, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Device 1020", 99.99m, 200, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Gadget 5738", 149.99m, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Gadget 7928", 0, 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 9293", 29.99m, 0, 50, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 8062", 1, 20, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 7747", 29.99m, 1, 50, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });
        }
    }
}

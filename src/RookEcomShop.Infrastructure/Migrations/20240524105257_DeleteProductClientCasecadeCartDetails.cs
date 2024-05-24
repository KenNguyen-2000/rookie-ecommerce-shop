using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RookEcomShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DeleteProductClientCasecadeCartDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Gadget 6019", 19.99m, 1, 200, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Widget 4360", 49.99m, 1, 10, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Gadget 6199", 149.99m, 1, 50, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Item 6714", 29.99m, 1, 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Device 6662", 19.99m, 0, 200, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Widget 4151", 99.99m, 1, 20, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Gadget 3693", 99.99m, 200, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Widget 5517", 0, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Device 6089", 49.99m, 50, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Gadget 3817", 19.99m, 0, 100, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Device 1209", 19.99m, 200, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Gadget 1675", 149.99m, 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Device 5607", 19.99m, 1, 100, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Widget 9946", 19.99m, 1, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Gadget 9687", 0, 10, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Widget 4452", 99.99m, 1, 200, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Thing 9731", 49.99m, 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Widget 3681", 149.99m, 0, 200, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Device 6090", 20, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Item 2365", 49.99m, 200, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Item 4665", 29.99m, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Gadget 4676", 19.99m, 0, 100, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Item 7892", 49.99m, 1, 200, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Device 2314", 149.99m, 20, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Thing 3186", 149.99m, 0, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Thing 9894", 149.99m, 1, 20, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Widget 3788", 29.99m, 1, 100, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Thing 3809", 29.99m, 50, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Item 2058", 99.99m, 10, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Widget 5678", 29.99m, 20, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Gadget 5302", 99.99m, 50, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Widget 7701", 49.99m, 50, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Thing 8745", 19.99m, 1, 50, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Device 6383", 19.99m, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Widget 3399", 99.99m, 200, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Gadget 7809", 0, 50, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Item 2894", 100, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Gadget 8348", 19.99m, 20, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Widget 5470", 29.99m, 1, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Thing 5430", 19.99m, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Widget 2155", 99.99m, 100, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Gadget 7291", 29.99m, 0, 100, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Device 3916", 29.99m, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Gadget 2029", 19.99m, 0, 200, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Device 1320", 49.99m, 1, 200, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Thing 3349", 29.99m, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Item 1489", 0, 20, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Device 8902", 99.99m, 0, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Widget 2963", 19.99m, 0, 20, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Gadget 4306", 149.99m, 20, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Thing 1432", 149.99m, 100, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Item 5880", 99.99m, 200, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Widget 1130", 49.99m, 1, 50, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Thing 7123", 100, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Gadget 3201", 99.99m, 200, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Device 8991", 1, 10, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Item 1940", 1, 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Device 4604", 29.99m, 1, 50, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Item 6343", new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Widget 6983", 19.99m, 100, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Widget 3403", 149.99m, 200, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Gadget 1178", 29.99m, 50, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Item 8407", 99.99m, 20, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Device 6741", 149.99m, 200, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Gadget 9705", 49.99m, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Gadget 9567", new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Item 4996", 149.99m, 0, 20, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Widget 3150", 19.99m, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Thing 3911", 149.99m, 50, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Gadget 7879", 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Device 6893", 99.99m, 1, 100, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Item 5261", 29.99m, 1, 200, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Thing 1041", 20, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Widget 4875", 49.99m, 200, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Item 4189", 29.99m, 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Widget 5533", 99.99m, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Thing 9422", 49.99m, 100, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Widget 5017", 149.99m, 0, 50, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Widget 2650", 99.99m, 200, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Thing 5554", 10, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Thing 4825", 149.99m, 20, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Device 1983", 149.99m, 0, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Device 5355", 29.99m, 50, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Widget 4257", 20, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Device 2318", 19.99m, 50, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Widget 7480", 19.99m, 200, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Device 3100", 99.99m, 0, 50, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Item 7619", 19.99m, 100, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Popular", "Gadget 8743", 100, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Widget 5872", 99.99m, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Widget 9820", 29.99m, 1, 10, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Limited edition", "Widget 6662", 19.99m, 1, 100, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Thing 4685", 29.99m, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Gadget 1824", 29.99m, 1, 200, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Widget 6965", 19.99m, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Device 3870", 19.99m, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "High quality", "Device 7066", 29.99m, 0, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Best seller", "Thing 3421", 149.99m, 0, 50, new DateTime(2024, 4, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Thing 4324", 1, 10, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648), "Brand new", "Item 6794", 149.99m, 0, 50, new DateTime(2024, 3, 24, 17, 52, 56, 856, DateTimeKind.Local).AddTicks(6648) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Widget 6268", 29.99m, 0, 10, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Gadget 4384", 99.99m, 0, 200, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Thing 1028", 99.99m, 0, 100, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Device 2861", 49.99m, 0, 50, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Widget 6039", 99.99m, 1, 50, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Item 4393", 19.99m, 0, 50, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Widget 4141", 29.99m, 20, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Device 6053", 1, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Widget 1280", 29.99m, 20, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Device 2873", 149.99m, 1, 20, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Gadget 2527", 149.99m, 20, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Item 3866", 29.99m, 20, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Thing 1444", 149.99m, 0, 200, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Gadget 7764", 29.99m, 0, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Device 1834", 1, 200, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Item 7083", 29.99m, 0, 50, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Gadget 6212", 149.99m, 20, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Item 3067", 99.99m, 1, 10, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Item 3583", 50, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Thing 1889", 29.99m, 10, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Widget 5316", 149.99m, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Thing 6535", 49.99m, 1, 200, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Item 3836", 19.99m, 0, 20, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Widget 8536", 49.99m, 10, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Gadget 9187", 99.99m, 1, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Item 7759", 29.99m, 0, 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Thing 8772", 99.99m, 0, 10, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Widget 3733", 49.99m, 100, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Gadget 1902", 29.99m, 20, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Item 8053", 49.99m, 50, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Thing 3007", 29.99m, 100, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Item 7940", 19.99m, 20, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Item 8032", 149.99m, 0, 200, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Item 4250", 49.99m, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Thing 8929", 149.99m, 50, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Widget 9378", 1, 20, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Widget 7750", 20, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Thing 7450", 149.99m, 50, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Widget 9663", 99.99m, 0, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Gadget 6740", 149.99m, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Widget 4734", 149.99m, 200, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Thing 4170", 49.99m, 1, 200, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Item 4979", 149.99m, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Thing 7464", 99.99m, 1, 50, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Thing 3122", 19.99m, 0, 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Gadget 6651", 19.99m, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Item 3465", 1, 200, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Device 4838", 29.99m, 1, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Widget 1169", 99.99m, 1, 50, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Thing 1452", 29.99m, 10, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Widget 2087", 99.99m, 10, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Device 1724", 29.99m, 10, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Item 2104", 29.99m, 0, 100, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Device 9735", 200, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Thing 8194", 149.99m, 50, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Widget 1845", 0, 20, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Thing 2317", 0, 200, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Widget 3724", 19.99m, 0, 20, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Item 4600", new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Device 8148", 49.99m, 50, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Item 7520", 19.99m, 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Item 6057", 19.99m, 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Device 3527", 149.99m, 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Widget 3869", 99.99m, 50, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Widget 4406", 19.99m, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Widget 1812", new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Device 4299", 99.99m, 1, 100, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Gadget 2968", 149.99m, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Item 3491", 29.99m, 20, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Device 4528", 50, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Thing 2650", 19.99m, 0, 10, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Gadget 2113", 99.99m, 0, 20, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Thing 3390", 200, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Widget 7106", 99.99m, 100, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Device 9596", 99.99m, 20, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Gadget 5928", 49.99m, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Gadget 2943", 149.99m, 50, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Item 7716", 99.99m, 1, 10, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Device 9622", 49.99m, 20, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Device 3542", 50, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Gadget 5449", 49.99m, 100, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Widget 4351", 29.99m, 1, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Device 3506", 99.99m, 100, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Widget 9843", 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Widget 1246", 29.99m, 100, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Thing 4198", 29.99m, 20, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Limited edition", "Device 7378", 149.99m, 1, 100, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Device 9648", 29.99m, 200, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Widget 9039", 50, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Device 7916", 149.99m, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Gadget 6982", 149.99m, 0, 200, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Gadget 1178", 49.99m, 0, 10, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Popular", "Gadget 6485", 149.99m, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Device 8283", 99.99m, 0, 20, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "High quality", "Device 8885", 49.99m, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Device 9195", 149.99m, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Gadget 7731", 19.99m, 1, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Brand new", "Widget 6278", 19.99m, 1, 20, new DateTime(2024, 4, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Widget 5499", 0, 100, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932), "Best seller", "Widget 1691", 99.99m, 1, 20, new DateTime(2024, 3, 24, 17, 50, 14, 226, DateTimeKind.Local).AddTicks(932) });
        }
    }
}

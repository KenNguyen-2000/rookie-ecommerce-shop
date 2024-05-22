using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RookEcomShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DeleteCartOnCasCade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Carts_CartId",
                table: "CartDetails");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Gadget 6519", 99.99m, 20, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Item 7147", 49.99m, 100, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Widget 8142", 99.99m, 200, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Gadget 6641", 99.99m, 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Gadget 5805", 49.99m, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

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
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Widget 5692", 99.99m, 1, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Device 8425", 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Widget 5324", 149.99m, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 2595", 19.99m, 0, 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Gadget 1014", 99.99m, 0, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 3551", 0, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Item 4222", 99.99m, 20, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Device 3657", 19.99m, 10, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Thing 9526", 1, 50, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Item 4400", 49.99m, 0, 200, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Gadget 2281", 19.99m, 200, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Gadget 7595", 99.99m, 200, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Item 6682", 149.99m, 0, 20, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Thing 5427", 49.99m, 0, 20, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 3549", 29.99m, 1, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Gadget 7436", 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Item 9274", 29.99m, 100, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Device 2379", new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Widget 1121", 99.99m, 200, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 6370", 29.99m, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Thing 8444", new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Gadget 6911", 99.99m, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Widget 4839", 19.99m, 200, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Gadget 6011", 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 3787", 100, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Widget 4189", 0, 10, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 8051", 19.99m, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Thing 6459", 99.99m, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Gadget 4362", 19.99m, 0, 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 8691", 1, 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 9818", 29.99m, 1, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Device 5513", 99.99m, 0, 100, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Device 5079", 29.99m, 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 5069", 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Widget 6143", 19.99m, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 7102", 19.99m, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Item 1222", 149.99m, 0, 20, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Device 6606", 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Device 4629", 149.99m, 1, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Item 6227", 149.99m, 0, 50, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Thing 3522", 49.99m, 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Gadget 8713", 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

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
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 7958", 19.99m, 0, 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Item 3411", 20, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Device 3778", 149.99m, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Widget 3489", 149.99m, 0, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Gadget 7197", 19.99m, 50, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Widget 6426", 0, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Widget 9383", 99.99m, 1, 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Widget 5166", 99.99m, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Widget 6997", 29.99m, 1, 100, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Gadget 5353", 100, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Item 1526", 29.99m, 10, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Device 6162", 99.99m, 0, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Item 7768", 99.99m, 20, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Thing 6381", 99.99m, 100, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 9705", 29.99m, 100, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Item 8941", 49.99m, 1, 20, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Widget 3006", 1, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Thing 4318", 29.99m, 0, 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Gadget 2229", 29.99m, 0, 20, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 9238", 100, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 9793", 1, 10, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

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
                columns: new[] { "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 8277", 99.99m, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Gadget 6798", 19.99m, 200, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Item 8820", new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Device 4440", 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 9130", 19.99m, 0, 100, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Gadget 9430", 19.99m, 0, 100, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

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
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Thing 8947", 49.99m, 100, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Thing 6996", 49.99m, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 5617", 49.99m, 1, 20, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Widget 2175", 99.99m, 0, 20, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Best seller", "Thing 8144", 19.99m, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Thing 6186", 29.99m, 0, 50, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Item 3093", 10, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 2297", 0, 100, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Popular", "Device 8465", 29.99m, 0, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 7358", 19.99m, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 3719", new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Device 1020", 1, new DateTime(2024, 3, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Limited edition", "Gadget 7928", 29.99m, 0, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Thing 9293", 29.99m, 50, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "Brand new", "Thing 8062", 149.99m, 20, new DateTime(2024, 4, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813), "High quality", "Item 7747", 29.99m, 1, 50, new DateTime(2024, 2, 22, 16, 3, 46, 744, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Carts_CartId",
                table: "CartDetails",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Carts_CartId",
                table: "CartDetails");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 6648", 49.99m, 50, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Widget 5500", 149.99m, 200, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Device 2523", 19.99m, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Device 9301", 29.99m, 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Device 1348", 29.99m, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Item 2601", 50, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Gadget 3794", 49.99m, 0, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Widget 6745", 200, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Widget 8858", 19.99m, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Item 5631", 29.99m, 1, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Thing 9782", 29.99m, 1, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Thing 7725", 1, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Thing 4473", 49.99m, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Item 3408", 49.99m, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Item 1616", 0, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Item 8358", 149.99m, 1, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Thing 7846", 49.99m, 20, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Thing 8825", 29.99m, 20, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 1849", 29.99m, 200, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Item 3997", 29.99m, 1, 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Item 2487", 99.99m, 1, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 4115", 19.99m, 0, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Item 8958", 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Device 6346", 149.99m, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 3463", new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Device 1518", 149.99m, 20, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Widget 8840", 49.99m, 20, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Gadget 9894", new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 2414", 149.99m, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Thing 8058", 99.99m, 20, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Device 1251", 20, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Gadget 9801", 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Widget 9023", 1, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Device 9722", 149.99m, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Device 2563", 19.99m, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Gadget 9524", 49.99m, 1, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 5993", 0, 100, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Thing 5041", 99.99m, 0, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Gadget 3512", 49.99m, 1, 50, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Device 5270", 149.99m, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Device 4581", 100, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Widget 3182", 149.99m, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Widget 2332", 99.99m, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Device 3590", 29.99m, 1, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Widget 3888", 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Item 7824", 49.99m, 0, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 4106", 49.99m, 1, 200, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Gadget 9461", 29.99m, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 4830", 100, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 3219", 99.99m, 1, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Thing 2457", 49.99m, 1, 50, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Widget 2553", 49.99m, 0, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 2679", 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Gadget 9107", 29.99m, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Device 2880", 99.99m, 1, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Widget 7673", 29.99m, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 4211", 99.99m, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Widget 3345", 1, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Thing 8433", 19.99m, 0, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Item 2371", 49.99m, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 7732", 49.99m, 0, 200, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Widget 3266", 20, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Thing 3902", 19.99m, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Device 6895", 29.99m, 1, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Thing 1154", 29.99m, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Item 2976", 149.99m, 200, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 2256", 99.99m, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Gadget 5245", 29.99m, 0, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Thing 4085", 0, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Thing 6138", 99.99m, 0, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Widget 7661", 99.99m, 1, 200, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Widget 2355", 19.99m, 1, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Item 1935", 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Device 1033", 0, 50, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Item 4708", 99.99m, 0, 20, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Widget 3152", 19.99m, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Device 5381", 99.99m, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Gadget 4793", new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Gadget 6093", 100, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Thing 3499", 29.99m, 1, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Device 9616", 19.99m, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Item 9721", 149.99m, 1, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Thing 9424", 29.99m, 0, 20, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Thing 5528", 99.99m, 10, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Thing 4052", 19.99m, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Widget 8456", 149.99m, 0, 100, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Device 9825", 149.99m, 1, 10, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Device 2031", 29.99m, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Widget 6355", 19.99m, 1, 200, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "StockQuantity", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Gadget 1454", 100, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Brand new", "Item 8672", 1, 10, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Widget 7024", 99.99m, 1, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 4960", 29.99m, new DateTime(2024, 3, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Thing 2862", new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Device 8024", 0, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "High quality", "Device 7878", 29.99m, 100, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Device 6136", 49.99m, 1, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Limited edition", "Widget 9115", 149.99m, 100, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Best seller", "Gadget 1858", 49.99m, 50, new DateTime(2024, 4, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583), "Popular", "Widget 9593", 19.99m, 0, 100, new DateTime(2024, 2, 19, 16, 46, 50, 652, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Carts_CartId",
                table: "CartDetails",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");
        }
    }
}

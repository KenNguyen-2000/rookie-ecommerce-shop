using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RookEcomShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeparateIdentityServer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTransactions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartDetails_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 12, null, null, "Grocery & Gourmet" },
                    { 13, 3, null, "Furniture" },
                    { 14, 3, null, "Appliances" },
                    { 15, 3, null, "Decor" },
                    { 16, 1, null, "Smartphones" },
                    { 17, 1, null, "Laptops" },
                    { 18, 1, null, "Tablets" },
                    { 19, 4, null, "Fiction" },
                    { 20, 4, null, "Non-Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Item 4539", 149.99m, 1, 200, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 2, 8, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Item 7930", 19.99m, 1, 10, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 3, 7, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Item 1277", 149.99m, 1, 100, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 4, 9, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Item 1042", 49.99m, 0, 50, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 5, 7, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Thing 6961", 49.99m, 0, 100, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 6, 11, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Item 9327", 49.99m, 0, 20, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 7, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Gadget 7204", 149.99m, 1, 100, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 8, 9, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Device 4903", 49.99m, 1, 100, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 9, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Item 1015", 149.99m, 1, 20, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 10, 11, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Gadget 1720", 149.99m, 0, 50, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 11, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Device 5926", 19.99m, 0, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 12, 5, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Device 4253", 149.99m, 0, 10, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 13, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Widget 8205", 19.99m, 1, 20, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 14, 5, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Device 6948", 29.99m, 0, 200, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 15, 2, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Gadget 7468", 29.99m, 1, 20, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 16, 9, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Thing 8413", 29.99m, 1, 100, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 17, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Gadget 8276", 19.99m, 1, 20, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 18, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Gadget 1427", 149.99m, 0, 200, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 19, 6, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Gadget 5237", 149.99m, 0, 200, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 20, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Device 6606", 99.99m, 0, 20, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 21, 6, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Gadget 2124", 99.99m, 1, 20, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 22, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Widget 6517", 49.99m, 0, 10, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 23, 8, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Widget 6734", 29.99m, 1, 100, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 24, 11, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Thing 8679", 29.99m, 1, 50, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 25, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Gadget 2225", 99.99m, 0, 50, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 26, 5, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Item 6522", 49.99m, 1, 20, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 27, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Device 8171", 29.99m, 0, 200, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 28, 4, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Thing 4368", 29.99m, 1, 10, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 29, 9, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Item 2357", 19.99m, 0, 20, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 30, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Widget 5993", 149.99m, 0, 200, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 31, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Device 6058", 99.99m, 1, 200, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 32, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Gadget 2337", 19.99m, 1, 50, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 33, 7, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Thing 2265", 29.99m, 0, 50, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 34, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Item 7520", 29.99m, 0, 50, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 35, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Item 8436", 149.99m, 0, 100, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 36, 8, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Item 9028", 149.99m, 1, 10, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 37, 9, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Thing 3262", 29.99m, 1, 20, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 38, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Item 9421", 149.99m, 0, 10, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 39, 5, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Device 9079", 149.99m, 1, 200, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 40, 11, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Device 7818", 29.99m, 1, 100, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 41, 6, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Thing 3719", 29.99m, 1, 20, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 42, 4, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Thing 9350", 29.99m, 1, 200, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 43, 5, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Item 7546", 99.99m, 0, 50, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 44, 7, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Gadget 4613", 19.99m, 1, 10, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 45, 5, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Widget 1933", 149.99m, 1, 200, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 46, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Widget 7839", 19.99m, 0, 100, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 47, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Widget 2311", 99.99m, 0, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 48, 2, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Item 9335", 149.99m, 0, 200, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 49, 4, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Widget 2829", 149.99m, 0, 50, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 50, 2, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Widget 3181", 149.99m, 0, 20, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 51, 7, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Item 2871", 149.99m, 1, 100, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 52, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Item 8402", 99.99m, 0, 100, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 53, 2, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Device 2661", 149.99m, 1, 50, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 54, 11, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Device 6856", 149.99m, 0, 10, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 55, 9, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Item 5094", 49.99m, 0, 20, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 56, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Thing 9974", 19.99m, 0, 100, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 57, 8, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Gadget 8139", 49.99m, 0, 100, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 58, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Gadget 9325", 19.99m, 0, 20, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 59, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Widget 5224", 149.99m, 0, 10, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 60, 11, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Gadget 6900", 149.99m, 1, 20, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 61, 7, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Device 3267", 49.99m, 1, 200, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 62, 5, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Device 3131", 19.99m, 0, 100, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 63, 8, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Device 8534", 149.99m, 1, 50, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 64, 8, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Thing 7668", 49.99m, 0, 10, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 65, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Device 9859", 19.99m, 1, 100, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 66, 7, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Item 2897", 99.99m, 0, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 67, 11, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Device 7264", 149.99m, 1, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 68, 5, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Device 1712", 29.99m, 1, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 69, 2, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Widget 5677", 19.99m, 1, 10, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 70, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Widget 3460", 29.99m, 0, 50, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 71, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Widget 7978", 49.99m, 0, 50, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 72, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Widget 2012", 149.99m, 0, 50, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 73, 4, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Item 2497", 19.99m, 1, 20, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 74, 11, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Thing 7745", 99.99m, 1, 100, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 75, 7, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Item 2061", 29.99m, 1, 50, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 76, 11, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Device 7310", 29.99m, 1, 100, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 77, 4, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Item 9495", 19.99m, 1, 200, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 78, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Item 2018", 99.99m, 0, 100, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 79, 5, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Gadget 2607", 29.99m, 0, 50, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 80, 2, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Item 3225", 29.99m, 1, 50, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 81, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Gadget 3291", 19.99m, 1, 100, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 82, 6, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Thing 8158", 49.99m, 1, 20, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 83, 2, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Item 5555", 49.99m, 0, 100, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 84, 4, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Item 5354", 149.99m, 0, 50, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 85, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Item 2335", 99.99m, 1, 10, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 86, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Item 1873", 19.99m, 0, 200, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 87, 6, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Gadget 1236", 149.99m, 1, 50, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 88, 9, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Device 7454", 29.99m, 1, 10, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 89, 7, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Thing 9604", 149.99m, 0, 20, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 90, 6, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Item 3553", 29.99m, 1, 20, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 91, 4, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Thing 7538", 19.99m, 0, 100, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 92, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Limited edition", "Item 6445", 49.99m, 1, 20, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 93, 12, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Device 6316", 29.99m, 0, 200, new DateTime(2024, 4, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 94, 9, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Gadget 6375", 19.99m, 1, 20, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 95, 8, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Gadget 3998", 99.99m, 0, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 96, 2, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Popular", "Gadget 2940", 29.99m, 1, 20, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 97, 10, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Brand new", "Gadget 5171", 49.99m, 1, 20, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 98, 8, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Thing 2618", 99.99m, 1, 10, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 99, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "High quality", "Device 4192", 19.99m, 0, 100, new DateTime(2024, 3, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 },
                    { 100, 3, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), "Best seller", "Item 6191", 149.99m, 0, 200, new DateTime(2024, 2, 27, 12, 12, 20, 60, DateTimeKind.Local).AddTicks(4545), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_CartId",
                table: "CartDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ProductId",
                table: "CartDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_OrderId",
                table: "PaymentTransactions",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "PaymentTransactions");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

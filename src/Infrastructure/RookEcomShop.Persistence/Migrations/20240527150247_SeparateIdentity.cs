using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RookEcomShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeparateIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    AvartarUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, 8, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Gadget 1755", 99.99m, 0, 20, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 2, 6, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Gadget 9970", 49.99m, 0, 20, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 3, 12, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Item 4974", 49.99m, 1, 100, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 4, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Device 3829", 29.99m, 1, 100, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 5, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Gadget 7494", 49.99m, 0, 20, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 6, 6, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Thing 6204", 49.99m, 1, 50, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 7, 9, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Device 9529", 49.99m, 0, 100, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 8, 2, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Item 1997", 29.99m, 0, 10, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 9, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Thing 7281", 99.99m, 1, 50, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 10, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Widget 9758", 29.99m, 1, 200, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 11, 3, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Device 2433", 29.99m, 1, 100, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 12, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Item 8918", 19.99m, 0, 20, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 13, 3, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Gadget 4991", 149.99m, 0, 100, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 14, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Widget 9907", 149.99m, 0, 200, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 15, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Device 4244", 29.99m, 0, 10, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 16, 7, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Thing 8215", 19.99m, 1, 100, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 17, 3, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Gadget 8266", 149.99m, 1, 10, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 18, 3, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Item 4277", 29.99m, 0, 20, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 19, 3, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Device 5425", 99.99m, 0, 20, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 20, 6, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Widget 9856", 149.99m, 0, 100, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 21, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Item 8122", 19.99m, 0, 50, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 22, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Device 4066", 29.99m, 0, 50, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 23, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Device 9698", 99.99m, 0, 50, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 24, 3, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Item 6108", 99.99m, 0, 100, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 25, 8, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Item 9988", 99.99m, 0, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 26, 12, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Device 8666", 29.99m, 0, 100, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 27, 7, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Device 8437", 49.99m, 0, 200, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 28, 4, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Item 2419", 99.99m, 0, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 29, 9, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Device 4400", 29.99m, 0, 20, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 30, 7, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Widget 6270", 29.99m, 1, 200, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 31, 12, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Device 5161", 99.99m, 1, 50, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 32, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Thing 3258", 29.99m, 1, 200, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 33, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Thing 1292", 19.99m, 1, 10, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 34, 9, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Item 6615", 149.99m, 0, 20, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 35, 6, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Thing 3907", 99.99m, 1, 200, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 36, 12, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Device 3981", 29.99m, 1, 100, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 37, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Widget 8650", 149.99m, 1, 100, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 38, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Thing 2042", 29.99m, 1, 20, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 39, 4, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Widget 4246", 49.99m, 0, 50, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 40, 9, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Thing 7890", 29.99m, 0, 20, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 41, 12, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Device 8099", 29.99m, 1, 50, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 42, 12, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Widget 8337", 49.99m, 0, 50, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 43, 12, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Thing 3215", 19.99m, 1, 50, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 44, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Item 8459", 19.99m, 0, 10, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 45, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Thing 7498", 19.99m, 0, 20, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 46, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Widget 4721", 19.99m, 1, 50, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 47, 7, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Device 5004", 149.99m, 1, 20, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 48, 9, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Thing 9502", 29.99m, 0, 50, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 49, 12, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Widget 7307", 29.99m, 1, 100, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 50, 2, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Device 2347", 19.99m, 0, 10, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 51, 4, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Widget 6568", 29.99m, 0, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 52, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Thing 9578", 149.99m, 1, 50, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 53, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Widget 2056", 149.99m, 0, 50, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 54, 3, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Widget 6768", 149.99m, 1, 50, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 55, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Device 2101", 49.99m, 1, 200, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 56, 4, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Gadget 4647", 29.99m, 0, 20, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 57, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Widget 3900", 19.99m, 0, 200, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 58, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Thing 5845", 19.99m, 1, 50, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 59, 9, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Thing 4914", 149.99m, 0, 10, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 60, 6, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Device 4999", 99.99m, 0, 50, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 61, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Widget 7219", 99.99m, 1, 50, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 62, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Gadget 6223", 29.99m, 1, 20, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 63, 9, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Widget 5994", 149.99m, 0, 20, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 64, 2, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Widget 5972", 19.99m, 1, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 65, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Item 9750", 29.99m, 0, 50, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 66, 12, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Thing 2481", 49.99m, 0, 100, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 67, 8, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Thing 6773", 19.99m, 0, 100, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 68, 7, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Thing 9485", 19.99m, 1, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 69, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Gadget 1764", 149.99m, 1, 200, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 70, 7, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Device 9610", 29.99m, 1, 100, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 71, 2, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Gadget 3869", 149.99m, 1, 100, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 72, 4, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Device 1957", 29.99m, 1, 200, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 73, 12, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Device 8176", 49.99m, 1, 20, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 74, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Thing 8563", 149.99m, 1, 100, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 75, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Thing 6061", 19.99m, 0, 20, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 76, 7, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Device 6084", 49.99m, 0, 20, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 77, 4, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Device 1685", 49.99m, 1, 20, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 78, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Gadget 2154", 99.99m, 0, 10, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 79, 9, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Widget 7997", 29.99m, 0, 200, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 80, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Thing 5060", 99.99m, 0, 20, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 81, 11, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Device 5093", 49.99m, 1, 200, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 82, 2, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Gadget 3375", 99.99m, 0, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 83, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Gadget 3577", 149.99m, 1, 50, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 84, 2, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Thing 4909", 19.99m, 1, 50, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 85, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Gadget 2779", 19.99m, 1, 50, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 86, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Widget 6378", 19.99m, 0, 200, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 87, 4, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Item 7565", 149.99m, 1, 20, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 88, 8, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Thing 7448", 19.99m, 1, 50, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 89, 12, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Widget 9564", 29.99m, 0, 10, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 90, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Gadget 2860", 49.99m, 1, 20, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 91, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Device 3237", 19.99m, 0, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 92, 8, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Limited edition", "Gadget 1884", 19.99m, 0, 50, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 93, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Popular", "Widget 2405", 49.99m, 0, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 94, 2, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Device 8138", 49.99m, 1, 10, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 95, 6, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Best seller", "Widget 4080", 19.99m, 0, 100, new DateTime(2024, 3, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 96, 10, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Gadget 8327", 19.99m, 0, 50, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 97, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Item 4589", 29.99m, 0, 20, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 98, 8, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "Brand new", "Widget 7702", 49.99m, 0, 10, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 99, 5, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Device 3009", 29.99m, 0, 200, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 },
                    { 100, 6, new DateTime(2024, 2, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), "High quality", "Device 6968", 29.99m, 1, 20, new DateTime(2024, 4, 27, 22, 2, 46, 271, DateTimeKind.Local).AddTicks(7376), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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

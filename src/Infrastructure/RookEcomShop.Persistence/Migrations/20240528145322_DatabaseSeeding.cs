using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RookEcomShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_UserId",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a1111111-1111-1111-1111-111111111111"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Essentials", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2222222-2222-2222-2222-222222222222"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Household", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a3333333-3333-3333-3333-333333333333"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hair Care", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4444444-4444-4444-4444-444444444444"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Oral Hygiene", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5555555-5555-5555-5555-555555555555"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clean Beauty", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6666666-6666-6666-6666-666666666666"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bath & Body", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a7777777-7777-7777-7777-777777777777"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Personal Hygiene", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("053d4c32-c4a3-4081-9547-2d18ebdb20b1"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Composing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("43985ad2-d09c-47ba-9b87-ce38fbf61faf"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dental Floss", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("43f2ea5a-a8f1-47e5-bc3d-e1ea1fb07c61"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dish Brushes", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("44c1d41b-5271-43a8-8a47-6ca81374ac59"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Period Care", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4700ad1a-055e-4814-aa42-75f003dc745b"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50e717cf-e8da-4d90-9a2b-6b684d09e15a"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Skin Care", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52e0be86-909b-4558-9338-03b4f0bb3fde"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Conditioner Bar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53c27ef5-14d9-446a-b781-7b0d58df197e"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bamboo Hair Brush", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("732eb72b-eb32-49f4-93b3-683a8cca8942"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tech", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("739d9491-e2d5-4d72-9627-32743c16e7ca"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cleaning", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("80d2efc8-e66a-46d8-b752-354b14c543fe"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ZWS Essentials", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8adcc1b4-56e3-4711-b3e1-4794835b87dd"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Laundry Detergent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("914d6831-75ed-404d-94f7-ed2256a3d478"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Endangered Tees", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0b247f2-3726-4f4e-ae6a-3f0aa5abfd2a"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Soap Bars", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1c8b9ee-1482-4fc2-b681-4bb0e411e3b0"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beding & Bath", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba7eb260-f67e-44da-881c-e15eac56a516"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Deodorant", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1ad4a8f-ff32-45f1-8e8d-1dbd1673d003"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Toothpaste", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cff753ce-9806-4084-8962-2a1bfd5853bf"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Suds & Eco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2db99a5-34fd-4540-9ce7-b13782f7b0c4"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pet Care", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7be10c9-e731-406f-8d32-7b398cee31ad"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bamboo Toothbrush", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e866546c-5457-4996-a5f4-89d49886312c"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Makeup", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee9177a6-1ecf-46f8-8808-d8e3403a2bd3"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kids & Baby", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8173aae-245d-4bfa-a3ab-d7f3c698ea32"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Shampoo Bar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc0887fe-973e-4023-8307-de5cd99c35a5"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Shaving", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("06ed5536-0439-4d60-b747-73514ea5de08"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Widget 7977", 149.99m, 1, 50, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("0a75e9af-084e-42df-ace8-38989fc2c487"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Widget 5073", 99.99m, 1, 10, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("0ae0f741-b246-40ac-be81-7bcdc463bbf8"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 6125", 149.99m, 0, 100, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("0e6b7bcc-f94f-48e4-be3f-5fbf5c2264a2"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Gadget 1672", 29.99m, 0, 20, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("0fdb9edb-f6d8-42c8-b189-4f7ee670d740"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Widget 9451", 49.99m, 0, 100, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("11823cd7-9053-43b9-8631-4f5a861235c1"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Thing 4801", 29.99m, 1, 20, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("16777562-589e-471c-8fbc-46bdaedbd666"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Device 5826", 19.99m, 1, 50, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("16ffbd30-f9d8-4b95-bad3-dc538bbbf0a6"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Gadget 8810", 29.99m, 1, 10, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("18b530cf-c5c1-4144-bf7d-ee940db57bab"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Item 3680", 149.99m, 1, 10, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("1aeed1bd-b69f-4f9c-8076-f493fb70047d"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Thing 2057", 29.99m, 0, 10, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("1bcfbf49-8ed5-48a1-8a9b-8e1904235f7d"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Gadget 2752", 149.99m, 1, 20, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("1d90e031-5b44-4000-b6a6-ac0f2f970467"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Item 9743", 49.99m, 1, 200, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("1f16df41-cec0-4b11-8652-6a2046d48b1b"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Item 8559", 149.99m, 0, 10, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("221f92b7-906d-4dbe-8c7a-442e76e9129a"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Item 8709", 99.99m, 1, 20, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("22346c5d-7054-4b7f-859c-b7aedf0ef89a"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Widget 3284", 99.99m, 1, 20, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("23ace7e2-ed35-45b6-a4f3-dbc3e565f6ec"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Device 7434", 49.99m, 1, 100, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("23ffb112-1466-4d10-aca0-0f7153cc387f"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Widget 3295", 49.99m, 1, 50, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("25b2986c-0d6d-4317-a563-5a4d2f2434cc"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Device 6826", 99.99m, 0, 100, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("25ba14fd-9aa8-417f-9eee-87b3168c9202"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Device 9582", 29.99m, 0, 50, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("2649230f-084b-4992-ad01-0e7b60b7ec78"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Thing 8903", 99.99m, 1, 10, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("28387c08-ed29-449f-a0c5-3a75e24c328d"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Item 9750", 19.99m, 1, 50, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("290458f5-b56c-4f10-aa13-3c35847724c0"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Widget 7025", 29.99m, 0, 10, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("295baf1c-b328-4514-80aa-cea377e27bcd"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Widget 2712", 99.99m, 1, 200, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("2b0f5968-86b9-4bb3-87da-de41b8ab9477"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Gadget 7069", 149.99m, 1, 100, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("2b955f4b-1411-448b-a592-1a217d41d569"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Device 3134", 99.99m, 1, 200, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("2e02a642-247c-4023-bee4-39eb2a6b102d"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Widget 5507", 149.99m, 1, 20, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("360113c4-af1c-46e0-92db-b753a2e41cf0"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Device 7975", 29.99m, 1, 200, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("382a045c-e183-47ca-8a9d-cefcaecb9bdb"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Item 6017", 49.99m, 0, 20, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("3d8d5f02-6ba7-4e71-aec8-c4c3d359dc9f"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Device 3126", 29.99m, 0, 100, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("406afa19-da94-478b-9f7c-88968786584d"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Item 5553", 29.99m, 0, 10, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("42375469-013e-4f59-94bb-6e51aa0e4f72"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 7844", 149.99m, 0, 50, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("42403854-2fb7-4dcc-8ef5-6514f2b8622c"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Thing 5144", 19.99m, 0, 200, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("425e6046-ce0f-4fb3-ada3-9effa7195ca0"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Widget 7074", 99.99m, 1, 200, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("42c426e6-41eb-4129-89b3-35f754fa6bbe"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Gadget 3278", 149.99m, 1, 50, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("4924774a-2dd4-4aab-b0a7-f947b166b4ec"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Device 5414", 19.99m, 1, 100, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("4cf5f7c4-6d08-4afd-a617-5a563fa1af76"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Thing 6961", 149.99m, 0, 50, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("4d40a4f8-da56-4faa-bba3-0e839313f7e4"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Item 6005", 19.99m, 0, 200, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("4ec0e95c-06a4-491a-865a-32c2779140f1"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Device 9186", 149.99m, 1, 20, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("5236b192-1e55-4ec4-a4ef-53e362f5b29a"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Item 2225", 19.99m, 1, 100, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("55b0500a-3fdf-4716-a909-089eda266c3d"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Item 7165", 49.99m, 0, 200, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("603dc882-f3ab-464f-942d-c29aeb6c8d61"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Device 7685", 19.99m, 1, 10, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("615a29de-3918-4d66-b207-2807007b5ee1"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 9038", 29.99m, 0, 50, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("6262a489-2124-46fd-937b-bddc806c2bfd"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Thing 6339", 99.99m, 1, 100, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("638134f3-e8fe-4357-9fdb-3e60be24407b"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Widget 1939", 49.99m, 1, 100, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("6acd86d4-488b-4ad3-80d5-c34793cfb1eb"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Item 9812", 99.99m, 1, 200, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("6b740947-7aa4-43c4-9e42-e12dc6b41102"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Widget 2702", 99.99m, 0, 10, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("6be9c4bd-a425-4d6a-89b0-262b6af12290"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 2843", 19.99m, 1, 10, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("6c7a8733-3db3-40bc-ae23-5cd770d0a13c"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Device 2676", 49.99m, 1, 20, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("70318ffd-a2d5-4900-8dc0-6bd62fb743e0"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 8075", 99.99m, 0, 200, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("713482c1-b95a-489e-8756-758ac0b8f9da"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Device 4599", 149.99m, 1, 200, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("740c4584-de0b-4b8e-9594-8d7973cb5499"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 9711", 19.99m, 1, 50, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("788ef9e9-8952-4186-81a5-43716e559040"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Item 1995", 149.99m, 0, 50, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("7f2e8046-8c98-4ab0-b45d-dea57f7b8db5"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Widget 1677", 49.99m, 0, 50, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("825fc059-e09d-4ba4-8d3d-3407b41a42b0"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Gadget 4373", 149.99m, 0, 50, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("84cfebe6-7c1e-4627-b378-99a6347f16f0"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Gadget 8675", 149.99m, 0, 20, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("8a69affd-4e10-445e-bc07-34187dd8f459"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Gadget 6123", 149.99m, 0, 200, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("8b92c2df-9272-4eea-ae48-f05705014449"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Device 1390", 49.99m, 0, 10, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("93f87466-1c9a-4bb0-9430-03ed45c4fba4"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Gadget 3385", 49.99m, 0, 10, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("96a07299-7adc-4c75-be67-fac8c308917a"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Item 7992", 99.99m, 1, 200, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("9700aa83-8164-41a0-a071-cb1000b0f127"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Widget 3584", 49.99m, 1, 100, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("98e21a00-e4bc-4170-9ac0-12d09b4d6f01"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Item 1934", 29.99m, 1, 200, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("99e8e95c-18ab-4859-8d72-60fd2d3ee617"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Item 3009", 99.99m, 1, 100, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("9ac007cb-35c9-48d7-902b-1acca071bbbf"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Device 2622", 99.99m, 0, 10, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("a10d5fdb-5b55-4189-ac0c-0a3d29338570"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Device 6151", 49.99m, 0, 10, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("a297efe6-8254-4b22-ae8d-e6933f53f746"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Widget 6907", 99.99m, 0, 100, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("aad6284c-4680-4067-ba7f-6243b90e3b80"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Gadget 3588", 19.99m, 0, 50, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("acd4a96f-5e81-47fc-bfef-5ad24db3bf5b"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Gadget 3432", 19.99m, 0, 10, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("b5907e98-adc7-41eb-9fe7-d0d76f48abcf"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Thing 4245", 19.99m, 1, 20, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("b6661bc6-5ac7-4e35-af28-62167644b635"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Thing 3630", 149.99m, 0, 10, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("ba87717d-2313-4306-a07e-d1205d21ff04"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Thing 4606", 49.99m, 0, 20, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("bc440a42-ecf9-4464-8ca0-67b5f3e0a1f5"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Gadget 7761", 29.99m, 0, 20, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("bc6ac440-7569-43b3-a6d6-a06112e45c1c"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Gadget 9792", 29.99m, 0, 200, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("c2d89898-400e-42e1-ae9c-b4a2538d7b8e"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Item 5519", 49.99m, 1, 100, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("c303b1b0-a7da-4be3-a7d3-21bc7c944598"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 2637", 99.99m, 0, 10, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("c4f4d702-d8d7-4003-9683-aac03923fbe8"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 8625", 29.99m, 1, 100, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("c6ab07c3-a738-4705-9194-3025a5a02b1a"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Device 4898", 99.99m, 1, 100, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("c8ec3f12-408c-438b-b5dc-f490eb2055fc"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Device 5037", 19.99m, 1, 20, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("c9dc8d90-77b3-4b15-8bc9-a893d936933f"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 7040", 149.99m, 0, 200, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("cbd72608-87d6-461c-816b-edfd058d7230"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Device 4341", 49.99m, 1, 200, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("cca8a82a-fee0-4fb0-98ff-056a047faaef"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Device 4375", 149.99m, 1, 10, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("cd5c0945-38df-4a23-8b7c-4bdc8b1e739b"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Device 3839", 29.99m, 1, 100, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("cde7378a-c88d-4bb4-8428-b1f54adf6c67"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Item 2096", 29.99m, 1, 50, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("d05a1b94-cbb9-4390-b312-b90e2b650a76"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 3894", 99.99m, 1, 200, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("d49a992c-74ca-44c1-8028-6b2eb4e398a7"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "High quality", "Item 6734", 149.99m, 0, 100, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("d5f64767-03dd-47f0-bdc4-c109806e7d35"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Device 5784", 49.99m, 0, 200, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("d7efda14-29d0-44f5-bf7b-8885431881bd"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Item 7002", 29.99m, 0, 50, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("d940cd3f-b10d-4985-bd67-de698b3394dc"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Thing 4520", 99.99m, 0, 50, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("df488ef8-f83c-4deb-9f74-3b423042b4ac"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Thing 3292", 19.99m, 1, 100, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("e204a1f2-655f-4e31-82ab-07da6b29f0de"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Gadget 6745", 19.99m, 0, 10, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("e88a99e7-17f9-413c-9c74-1b55e66156b4"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Thing 1777", 49.99m, 1, 200, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("eaf66102-9bb2-4515-8b25-1182553db91f"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Device 7436", 19.99m, 1, 10, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("ecc47cfd-bdd8-429c-a70a-4571e6e5e41b"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Limited edition", "Item 4890", 149.99m, 1, 200, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("eddb2afe-4a21-4726-be81-86d3a734a1a0"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Item 9163", 149.99m, 0, 50, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("ef50bea0-ec35-4e53-b29c-44d3c2bd97e3"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 7055", 19.99m, 1, 100, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("f883dced-087b-427f-983a-dd3bc90d31f8"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Thing 3488", 49.99m, 1, 50, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("f8b2a2e5-43a8-43b8-9095-9148343d126b"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Widget 2987", 149.99m, 1, 200, new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("fb2c2b32-0e24-4894-8bbb-f9437dcb2e83"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Brand new", "Thing 5550", 49.99m, 0, 20, new DateTime(2024, 4, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("fe7ce759-c221-47cd-b10d-3b98d7a9a39a"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Widget 8494", 149.99m, 1, 10, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("ff347e44-4f18-43f1-bcec-1c1397fce56f"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Popular", "Gadget 4094", 29.99m, 0, 100, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null },
                    { new Guid("ffeb15b4-1ada-4958-b75b-e8d62c8d45dc"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), "Best seller", "Thing 3616", 49.99m, 1, 10, new DateTime(2024, 3, 28, 21, 53, 21, 764, DateTimeKind.Local).AddTicks(2142), null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_UserId",
                table: "Products",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_UserId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("053d4c32-c4a3-4081-9547-2d18ebdb20b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43985ad2-d09c-47ba-9b87-ce38fbf61faf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43f2ea5a-a8f1-47e5-bc3d-e1ea1fb07c61"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44c1d41b-5271-43a8-8a47-6ca81374ac59"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4700ad1a-055e-4814-aa42-75f003dc745b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50e717cf-e8da-4d90-9a2b-6b684d09e15a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52e0be86-909b-4558-9338-03b4f0bb3fde"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53c27ef5-14d9-446a-b781-7b0d58df197e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("732eb72b-eb32-49f4-93b3-683a8cca8942"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("739d9491-e2d5-4d72-9627-32743c16e7ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80d2efc8-e66a-46d8-b752-354b14c543fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8adcc1b4-56e3-4711-b3e1-4794835b87dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("914d6831-75ed-404d-94f7-ed2256a3d478"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a0b247f2-3726-4f4e-ae6a-3f0aa5abfd2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1c8b9ee-1482-4fc2-b681-4bb0e411e3b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba7eb260-f67e-44da-881c-e15eac56a516"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1ad4a8f-ff32-45f1-8e8d-1dbd1673d003"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cff753ce-9806-4084-8962-2a1bfd5853bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2db99a5-34fd-4540-9ce7-b13782f7b0c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7be10c9-e731-406f-8d32-7b398cee31ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e866546c-5457-4996-a5f4-89d49886312c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee9177a6-1ecf-46f8-8808-d8e3403a2bd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8173aae-245d-4bfa-a3ab-d7f3c698ea32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc0887fe-973e-4023-8307-de5cd99c35a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06ed5536-0439-4d60-b747-73514ea5de08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a75e9af-084e-42df-ace8-38989fc2c487"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ae0f741-b246-40ac-be81-7bcdc463bbf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e6b7bcc-f94f-48e4-be3f-5fbf5c2264a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fdb9edb-f6d8-42c8-b189-4f7ee670d740"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11823cd7-9053-43b9-8631-4f5a861235c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16777562-589e-471c-8fbc-46bdaedbd666"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16ffbd30-f9d8-4b95-bad3-dc538bbbf0a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18b530cf-c5c1-4144-bf7d-ee940db57bab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1aeed1bd-b69f-4f9c-8076-f493fb70047d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bcfbf49-8ed5-48a1-8a9b-8e1904235f7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d90e031-5b44-4000-b6a6-ac0f2f970467"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f16df41-cec0-4b11-8652-6a2046d48b1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("221f92b7-906d-4dbe-8c7a-442e76e9129a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22346c5d-7054-4b7f-859c-b7aedf0ef89a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23ace7e2-ed35-45b6-a4f3-dbc3e565f6ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23ffb112-1466-4d10-aca0-0f7153cc387f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25b2986c-0d6d-4317-a563-5a4d2f2434cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25ba14fd-9aa8-417f-9eee-87b3168c9202"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2649230f-084b-4992-ad01-0e7b60b7ec78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28387c08-ed29-449f-a0c5-3a75e24c328d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("290458f5-b56c-4f10-aa13-3c35847724c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("295baf1c-b328-4514-80aa-cea377e27bcd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b0f5968-86b9-4bb3-87da-de41b8ab9477"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b955f4b-1411-448b-a592-1a217d41d569"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e02a642-247c-4023-bee4-39eb2a6b102d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("360113c4-af1c-46e0-92db-b753a2e41cf0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("382a045c-e183-47ca-8a9d-cefcaecb9bdb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d8d5f02-6ba7-4e71-aec8-c4c3d359dc9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("406afa19-da94-478b-9f7c-88968786584d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42375469-013e-4f59-94bb-6e51aa0e4f72"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42403854-2fb7-4dcc-8ef5-6514f2b8622c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("425e6046-ce0f-4fb3-ada3-9effa7195ca0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42c426e6-41eb-4129-89b3-35f754fa6bbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4924774a-2dd4-4aab-b0a7-f947b166b4ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cf5f7c4-6d08-4afd-a617-5a563fa1af76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d40a4f8-da56-4faa-bba3-0e839313f7e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ec0e95c-06a4-491a-865a-32c2779140f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5236b192-1e55-4ec4-a4ef-53e362f5b29a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55b0500a-3fdf-4716-a909-089eda266c3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("603dc882-f3ab-464f-942d-c29aeb6c8d61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("615a29de-3918-4d66-b207-2807007b5ee1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6262a489-2124-46fd-937b-bddc806c2bfd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("638134f3-e8fe-4357-9fdb-3e60be24407b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6acd86d4-488b-4ad3-80d5-c34793cfb1eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b740947-7aa4-43c4-9e42-e12dc6b41102"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6be9c4bd-a425-4d6a-89b0-262b6af12290"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c7a8733-3db3-40bc-ae23-5cd770d0a13c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70318ffd-a2d5-4900-8dc0-6bd62fb743e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("713482c1-b95a-489e-8756-758ac0b8f9da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("740c4584-de0b-4b8e-9594-8d7973cb5499"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("788ef9e9-8952-4186-81a5-43716e559040"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f2e8046-8c98-4ab0-b45d-dea57f7b8db5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("825fc059-e09d-4ba4-8d3d-3407b41a42b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84cfebe6-7c1e-4627-b378-99a6347f16f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a69affd-4e10-445e-bc07-34187dd8f459"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b92c2df-9272-4eea-ae48-f05705014449"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93f87466-1c9a-4bb0-9430-03ed45c4fba4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96a07299-7adc-4c75-be67-fac8c308917a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9700aa83-8164-41a0-a071-cb1000b0f127"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98e21a00-e4bc-4170-9ac0-12d09b4d6f01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99e8e95c-18ab-4859-8d72-60fd2d3ee617"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ac007cb-35c9-48d7-902b-1acca071bbbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a10d5fdb-5b55-4189-ac0c-0a3d29338570"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a297efe6-8254-4b22-ae8d-e6933f53f746"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aad6284c-4680-4067-ba7f-6243b90e3b80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("acd4a96f-5e81-47fc-bfef-5ad24db3bf5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5907e98-adc7-41eb-9fe7-d0d76f48abcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6661bc6-5ac7-4e35-af28-62167644b635"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba87717d-2313-4306-a07e-d1205d21ff04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc440a42-ecf9-4464-8ca0-67b5f3e0a1f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc6ac440-7569-43b3-a6d6-a06112e45c1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2d89898-400e-42e1-ae9c-b4a2538d7b8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c303b1b0-a7da-4be3-a7d3-21bc7c944598"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4f4d702-d8d7-4003-9683-aac03923fbe8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6ab07c3-a738-4705-9194-3025a5a02b1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8ec3f12-408c-438b-b5dc-f490eb2055fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9dc8d90-77b3-4b15-8bc9-a893d936933f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbd72608-87d6-461c-816b-edfd058d7230"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cca8a82a-fee0-4fb0-98ff-056a047faaef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd5c0945-38df-4a23-8b7c-4bdc8b1e739b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cde7378a-c88d-4bb4-8428-b1f54adf6c67"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d05a1b94-cbb9-4390-b312-b90e2b650a76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d49a992c-74ca-44c1-8028-6b2eb4e398a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5f64767-03dd-47f0-bdc4-c109806e7d35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7efda14-29d0-44f5-bf7b-8885431881bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d940cd3f-b10d-4985-bd67-de698b3394dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df488ef8-f83c-4deb-9f74-3b423042b4ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e204a1f2-655f-4e31-82ab-07da6b29f0de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e88a99e7-17f9-413c-9c74-1b55e66156b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eaf66102-9bb2-4515-8b25-1182553db91f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ecc47cfd-bdd8-429c-a70a-4571e6e5e41b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eddb2afe-4a21-4726-be81-86d3a734a1a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef50bea0-ec35-4e53-b29c-44d3c2bd97e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f883dced-087b-427f-983a-dd3bc90d31f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8b2a2e5-43a8-43b8-9095-9148343d126b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb2c2b32-0e24-4894-8bbb-f9437dcb2e83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe7ce759-c221-47cd-b10d-3b98d7a9a39a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff347e44-4f18-43f1-bcec-1c1397fce56f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffeb15b4-1ada-4958-b75b-e8d62c8d45dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7777777-7777-7777-7777-777777777777"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_UserId",
                table: "Products",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

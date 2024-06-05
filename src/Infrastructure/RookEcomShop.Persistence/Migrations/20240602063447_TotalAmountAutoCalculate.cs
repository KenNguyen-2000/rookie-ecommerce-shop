using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RookEcomShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TotalAmountAutoCalculate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basic necessities for everyday use", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Products for maintaining your home", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hair care products for all types", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Items to keep your oral health in check", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beauty products with clean ingredients", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Products for bath and body care", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Personal care products for hygiene", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("155605fe-7a2e-4010-b3ea-8aa7ff56304f"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eco-friendly shaving essentials", "Shaving", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("15902023-6082-4ec9-a427-10e24731afd9"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zero waste lifestyle essentials", "ZWS Essentials", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("15d9a485-f785-4c30-9ef0-7ffa35ec21aa"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eco-friendly bamboo hair brushes", "Bamboo Hair Brush", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("2c093f7d-5096-416c-a5b4-3963b84e697e"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "T-shirts supporting endangered species", "Endangered Tees", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("3f84d418-eb9c-43c7-8e39-5577811e2ae5"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean and natural makeup products", "Makeup", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("51674750-c845-4c99-a26f-9e1960ca25ab"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eco-friendly dental floss options", "Dental Floss", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("56a75187-7bc6-4607-9338-294829bbb0ed"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solid shampoo bars for various hair types", "Shampoo Bar", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("670aad6b-5c9c-4c29-b757-40c3c5ac0886"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kitchen tools and accessories", "Kitchen", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("6a1774f5-c10b-4d4e-b7a7-ecba2ce08fef"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Composting supplies for waste management", "Composting", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("80bf8642-812f-4b3d-bc01-644a32c043c1"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable bedding and bath items", "Bedding & Bath", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("853344cc-d20f-48d7-8c5c-1c50ee18645e"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natural and effective deodorants", "Deodorant", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("8cebbee8-561d-4bdb-ac37-e1c963e9b98f"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natural skincare products", "Skin Care", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("9b9d4068-e5d7-474d-8c38-7e3e10a6e208"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted soap bars with natural ingredients", "Soap Bars", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("a05f6d9b-36eb-4137-ab3e-cd282c9c2e02"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eco-friendly dishwashing brushes", "Dish Brushes", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("a44607f0-aa9c-4bee-9ab5-bd9dfc8a8792"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sustainable bamboo toothbrushes", "Bamboo Toothbrush", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("ac7049a4-9da5-4e0e-8482-92ac21c689df"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sustainable period care products", "Period Care", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("b1b5c4f5-0430-44d8-bd3f-1ba60b1ca863"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solid conditioner bars for healthy hair", "Conditioner Bar", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("bd61cd95-7349-4a09-8fa3-5480edb41a23"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sustainable tech gadgets and accessories", "Tech", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("c1e97731-1f95-46ec-a84a-538c6121491d"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Products for pet health and care", "Pet Care", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("cef0de44-c102-41ee-9fe1-38e6b28d6fcf"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Safe and eco-friendly products for kids and babies", "Kids & Baby", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("d36b1057-3252-4b15-9963-5ed1e52ec057"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eco-friendly laundry detergents", "Laundry Detergent", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("dc26c7b6-9824-4fba-81a8-440a8c688785"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleaning supplies for a tidy home", "Cleaning", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("de7cdb3f-fd9a-4d2b-b161-6ce18540ce42"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eco-friendly cleaning essentials", "Suds & Eco", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) },
                    { new Guid("e2ab06f3-da29-481c-8042-2f9d109b9550"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natural and effective toothpaste", "Toothpaste", new DateTime(2024, 6, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(8329) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "Price", "Status", "StockQuantity", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("00a3cd44-cb35-4fb5-8ea7-eca4e30908b1"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Device 4852", 19.99m, 0, 20, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("00bb7e1c-cf94-491c-bbf0-465154295296"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Gadget 9273", 149.99m, 1, 50, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("01c0c799-cae9-431f-8435-398a6c323aa3"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Item 5884", 29.99m, 0, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("01d09646-a3d3-4545-9639-c8b328db9f88"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Thing 5695", 149.99m, 0, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("02d22685-28e2-466c-aa10-79a50bdcbcfd"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Widget 3195", 49.99m, 0, 100, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("092412cd-5c88-4bc0-b468-0dd8ebcbab9e"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Item 7111", 149.99m, 0, 50, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("0b3af681-2096-48e2-865a-b14c8207937f"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Thing 3694", 49.99m, 1, 50, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("0b62b171-9620-453d-a9d4-ff9f494128db"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Item 2174", 149.99m, 0, 200, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("0ec15b37-de63-465d-b42a-76d39b14294b"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Gadget 3960", 29.99m, 1, 20, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("1019d790-7584-44ae-8f85-4b8eca5659ce"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Device 9113", 99.99m, 0, 200, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("23d93747-3e19-4045-8b5a-4a3fd6946a71"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Item 3332", 99.99m, 0, 50, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("25ba5df6-a915-4d6d-966c-420ff1e55aec"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Widget 9861", 149.99m, 0, 10, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("2606f580-6fee-4e62-baba-88cfad911fc3"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Item 7708", 149.99m, 0, 10, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("28bd17d8-ecc9-4a69-8b70-d09ca75096ce"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Thing 7258", 19.99m, 0, 50, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("2c4af36a-11c8-44e2-924b-456d81705471"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Thing 3813", 49.99m, 1, 100, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("3483faa7-231d-40cd-9253-d4d7755a7738"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Item 9994", 19.99m, 1, 200, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("355c672f-4e5a-47cc-aded-a8f5b0a5464b"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Device 2824", 29.99m, 0, 20, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("35a9805a-f92c-49d2-9035-9f094143a63a"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Item 4099", 149.99m, 1, 20, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("37c62de0-138f-43aa-95cc-07e2ea44784d"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Gadget 8223", 99.99m, 1, 10, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("3963fe8e-9c1b-44fb-9332-ca5fa175c325"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Thing 2752", 99.99m, 0, 20, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("3a9ba03e-b21a-43e1-a24e-f26a841bea3a"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Gadget 2878", 19.99m, 1, 200, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("3ae37f15-8625-4c32-bfb0-b947c1af5bae"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Item 4594", 19.99m, 0, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("3b06663e-5493-487f-926e-8146227c277a"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Widget 1263", 19.99m, 1, 20, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("3bf21922-f480-438a-8d6f-1a70ee14d922"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Thing 2668", 99.99m, 1, 10, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("3c8630fc-9e06-4306-9018-8555750721c5"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Widget 6954", 149.99m, 1, 100, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("44ffe532-2547-4dca-813a-ea1a3048ef3c"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Widget 5528", 29.99m, 0, 10, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("459aa7d9-537f-427f-b251-184033004303"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Widget 6283", 49.99m, 1, 200, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("47e1a2c2-5e25-4ddd-b8f2-dbb0aa12d24b"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Thing 2189", 19.99m, 0, 100, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("4c558f47-8be1-4791-817d-0408eec25bca"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Gadget 9011", 29.99m, 1, 50, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("4d8953bd-08e7-4eb8-9286-cc548a799c5d"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Item 3314", 19.99m, 1, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("4eeca808-9b12-4da8-b7cc-d194c322c9f5"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Thing 1625", 19.99m, 1, 100, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("51d07665-5a93-4ff9-bf33-9bb6f6da3f66"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Gadget 1898", 149.99m, 0, 100, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("5551552b-d765-4033-a0af-6b47fdccd74a"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Item 7505", 19.99m, 1, 20, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("55534134-af6f-4352-ba78-f897c672c0c3"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Item 6699", 99.99m, 0, 200, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("59d7600c-b29e-4e7d-b4ee-bb46aace9b92"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Device 7633", 49.99m, 1, 20, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("5aad49ea-5a3c-4c94-8cd9-d2c5a9a27960"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Gadget 4258", 149.99m, 1, 50, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("5b1ce82d-8cc8-4860-b535-57bf3df152b3"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Widget 2986", 99.99m, 0, 10, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("5c3fd87f-5f20-4f7d-899f-248444dd19f9"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Device 4128", 19.99m, 0, 100, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("612c2473-483c-498d-8c8c-244b18095758"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Thing 1072", 99.99m, 1, 10, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("64e0f2f1-e1bc-447e-aa4f-07056aa3cf9e"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Device 4927", 19.99m, 1, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("67f053ff-ca21-4da0-8e4d-20e9a7422254"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Item 1985", 29.99m, 0, 200, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("6bc7e468-5e67-4ba3-9c27-b1b208c1a929"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Device 3171", 49.99m, 1, 200, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("70ce2ede-6097-4a59-a3d1-0cb75d7b92f9"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Device 7519", 99.99m, 0, 20, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("70df24ff-d104-4b30-94f3-7af0353020fe"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Gadget 6339", 29.99m, 0, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("7a76e62f-d260-4379-8543-e4601d402a78"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Item 6228", 99.99m, 1, 10, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("7c3ef507-240b-4200-994e-4c1e4ad88e86"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Device 5226", 99.99m, 0, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("7e0b7863-f1d9-4a16-af33-409cc0466030"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Item 7990", 19.99m, 1, 100, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("7e263a19-f6cf-4e1f-ab2c-d489c85d13b8"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Device 2197", 149.99m, 0, 50, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("7f3cde87-0c27-4433-bea9-fc283029eba3"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Device 3367", 149.99m, 0, 10, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("807054eb-5348-4894-a6d4-7fc7f461bf18"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Thing 3970", 99.99m, 1, 10, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("8603d6cc-8a21-421d-b7e6-18435d819db0"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Thing 8602", 49.99m, 1, 20, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("88745091-439b-4979-bf3c-39e05f2c5fb3"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Widget 1404", 49.99m, 1, 100, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("8ca8bdc9-abd4-45c5-9d67-f7e7eb1fc629"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Device 6131", 49.99m, 1, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("8d087737-24e0-40a9-a784-02ea1faa3678"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Widget 7856", 49.99m, 1, 200, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("8e7edd5b-15ce-41fa-a5d0-30d385beaea9"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Thing 7062", 19.99m, 1, 50, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("8ff33532-13fc-4198-9c82-e995b1ddfb0f"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Device 4755", 49.99m, 1, 50, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("8ff44e52-d948-4b36-bd6d-7f2980adbcf8"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Widget 8177", 29.99m, 0, 200, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("91008502-aec0-4cd3-b404-67d808204bd2"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Gadget 9185", 29.99m, 1, 10, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("94dda8c4-b481-44ab-878e-ba82e5207f3b"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Thing 1323", 29.99m, 0, 200, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("95a46c38-35a8-4a4d-9d67-5ecd83602480"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Device 8195", 149.99m, 0, 200, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("990d5951-cca4-4637-a8df-d61fa4a389a8"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Device 7793", 149.99m, 0, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("9a3fb921-6b7d-437b-9732-0498ad40b917"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Widget 9514", 49.99m, 1, 10, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("9b4afd9d-38dc-4e74-a834-7c6e17cd3f87"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Item 9547", 49.99m, 0, 200, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("9b63d6a9-a6da-479c-aae4-599acde859cf"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Device 2930", 49.99m, 0, 20, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("9d3d12b7-d050-48d9-b767-e93a7f8d2ab6"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Device 4835", 99.99m, 0, 100, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("a5dd7c06-1727-4ff7-8aad-129c67735f63"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Thing 8221", 149.99m, 1, 10, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("ab775cba-494a-4f14-860e-40cdf6baac9f"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Device 5553", 19.99m, 1, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("ae6b963e-62a7-4561-a33d-1321fea1f58b"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Device 9993", 149.99m, 1, 20, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("af8c2b79-ad3e-4cee-a20c-eef36d9a9571"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Widget 9630", 99.99m, 1, 200, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("b06e7a1f-d958-4f7c-88c8-9ce85ad3c65c"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Item 8378", 19.99m, 0, 100, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("b107287e-92cb-4c32-90d1-0c6aab3b1fe4"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Gadget 6397", 149.99m, 0, 10, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("b34321ad-6124-42e7-a100-2d525bdf669e"), new Guid("a6666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Item 2059", 99.99m, 1, 100, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("b76ca448-2469-4a33-9c4d-2108fcb6cc29"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Device 9048", 29.99m, 1, 100, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("b8005fa0-e776-4442-b316-eb171503a784"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Thing 8395", 149.99m, 0, 100, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("bc3ccb34-e434-4619-b882-a70082f6fedc"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Item 5381", 99.99m, 0, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("bda5c5d4-ca5e-4208-99fe-1a84f9a91727"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Gadget 8931", 149.99m, 1, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("bf0678bb-fc54-4192-8726-b94bef1663bd"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Thing 9094", 49.99m, 0, 10, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("bfa03325-0912-4478-bad4-39b23ec390d0"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Widget 9176", 49.99m, 0, 10, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("bfcc529c-3fed-49de-913c-f2c0f38d186a"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Widget 9992", 19.99m, 1, 20, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("c47c61ab-37d9-4ff6-8007-c9b91d95e3ae"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Gadget 8414", 19.99m, 0, 50, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("c5cb9393-5490-4eef-99e1-1e995f6ef1e2"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Thing 5977", 29.99m, 1, 20, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("cbaea109-0604-4888-bf4f-063cf4c85fcd"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Thing 2993", 99.99m, 0, 100, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("cd29ac15-c2eb-4e84-b595-2665d8025a84"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Item 7790", 19.99m, 0, 50, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("cfb8b7a1-bb1c-4e26-8fb9-ddf6d46029df"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Thing 8143", 19.99m, 0, 10, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("d0ebe003-1d23-4367-9407-9f62a250cf8e"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Gadget 6837", 19.99m, 0, 100, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("d44d890a-9631-4459-8111-0a27900f274c"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Item 8955", 29.99m, 1, 200, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("d579cc70-f4be-4685-b8dc-4cedafe7d27f"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Device 8118", 49.99m, 1, 100, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("df01b504-7c9f-402f-b717-7aec69434725"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Gadget 9160", 29.99m, 1, 100, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("e6f8659b-5084-443b-a675-1da076cfdafa"), new Guid("a4444444-4444-4444-4444-444444444444"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Gadget 1700", 29.99m, 1, 100, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("e845bb34-fc20-441c-be34-89deb4d3269f"), new Guid("a3333333-3333-3333-3333-333333333333"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Gadget 5258", 149.99m, 0, 20, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("ed43007b-b197-4c36-b121-366a8d99aaec"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Thing 6587", 49.99m, 1, 20, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("edb75929-b348-4401-a3f0-96678dc6da69"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Widget 2328", 149.99m, 0, 50, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("ef823fdd-dd61-472d-a81e-30dd815c1b4f"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "High quality", "Device 3966", 19.99m, 0, 20, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("f028d28e-643a-4583-b171-50c2f3e1decb"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Item 8440", 29.99m, 1, 200, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("f04ee24e-d017-451a-a3e1-8250a5bfa453"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Widget 9250", 49.99m, 1, 100, new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("f5de8e3f-700a-4f5d-8e22-d597f1067f5c"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Thing 6942", 49.99m, 0, 50, new DateTime(2024, 5, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("f819ff17-454a-41b4-ad34-de78157b51e7"), new Guid("a5555555-5555-5555-5555-555555555555"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Limited edition", "Gadget 7700", 19.99m, 1, 50, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("f83345eb-06c6-451a-88a1-62b1c308bda2"), new Guid("a1111111-1111-1111-1111-111111111111"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Popular", "Widget 6741", 49.99m, 0, 200, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("f9ee9278-0293-45a4-bd7d-3108235ee174"), new Guid("a2222222-2222-2222-2222-222222222222"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Brand new", "Item 3192", 99.99m, 0, 20, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null },
                    { new Guid("fff89fad-8c95-4ec5-9b0a-80fb1f84ec56"), new Guid("a7777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), "Best seller", "Thing 9915", 149.99m, 0, 100, new DateTime(2024, 4, 2, 13, 34, 44, 926, DateTimeKind.Local).AddTicks(9595), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("155605fe-7a2e-4010-b3ea-8aa7ff56304f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("15902023-6082-4ec9-a427-10e24731afd9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("15d9a485-f785-4c30-9ef0-7ffa35ec21aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c093f7d-5096-416c-a5b4-3963b84e697e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f84d418-eb9c-43c7-8e39-5577811e2ae5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51674750-c845-4c99-a26f-9e1960ca25ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56a75187-7bc6-4607-9338-294829bbb0ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("670aad6b-5c9c-4c29-b757-40c3c5ac0886"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a1774f5-c10b-4d4e-b7a7-ecba2ce08fef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80bf8642-812f-4b3d-bc01-644a32c043c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("853344cc-d20f-48d7-8c5c-1c50ee18645e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8cebbee8-561d-4bdb-ac37-e1c963e9b98f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b9d4068-e5d7-474d-8c38-7e3e10a6e208"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a05f6d9b-36eb-4137-ab3e-cd282c9c2e02"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a44607f0-aa9c-4bee-9ab5-bd9dfc8a8792"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac7049a4-9da5-4e0e-8482-92ac21c689df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1b5c4f5-0430-44d8-bd3f-1ba60b1ca863"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd61cd95-7349-4a09-8fa3-5480edb41a23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1e97731-1f95-46ec-a84a-538c6121491d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cef0de44-c102-41ee-9fe1-38e6b28d6fcf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d36b1057-3252-4b15-9963-5ed1e52ec057"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc26c7b6-9824-4fba-81a8-440a8c688785"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de7cdb3f-fd9a-4d2b-b161-6ce18540ce42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2ab06f3-da29-481c-8042-2f9d109b9550"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00a3cd44-cb35-4fb5-8ea7-eca4e30908b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00bb7e1c-cf94-491c-bbf0-465154295296"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01c0c799-cae9-431f-8435-398a6c323aa3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01d09646-a3d3-4545-9639-c8b328db9f88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02d22685-28e2-466c-aa10-79a50bdcbcfd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("092412cd-5c88-4bc0-b468-0dd8ebcbab9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b3af681-2096-48e2-865a-b14c8207937f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b62b171-9620-453d-a9d4-ff9f494128db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ec15b37-de63-465d-b42a-76d39b14294b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1019d790-7584-44ae-8f85-4b8eca5659ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23d93747-3e19-4045-8b5a-4a3fd6946a71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25ba5df6-a915-4d6d-966c-420ff1e55aec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2606f580-6fee-4e62-baba-88cfad911fc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28bd17d8-ecc9-4a69-8b70-d09ca75096ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c4af36a-11c8-44e2-924b-456d81705471"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3483faa7-231d-40cd-9253-d4d7755a7738"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("355c672f-4e5a-47cc-aded-a8f5b0a5464b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35a9805a-f92c-49d2-9035-9f094143a63a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37c62de0-138f-43aa-95cc-07e2ea44784d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3963fe8e-9c1b-44fb-9332-ca5fa175c325"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a9ba03e-b21a-43e1-a24e-f26a841bea3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ae37f15-8625-4c32-bfb0-b947c1af5bae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b06663e-5493-487f-926e-8146227c277a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bf21922-f480-438a-8d6f-1a70ee14d922"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c8630fc-9e06-4306-9018-8555750721c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44ffe532-2547-4dca-813a-ea1a3048ef3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("459aa7d9-537f-427f-b251-184033004303"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47e1a2c2-5e25-4ddd-b8f2-dbb0aa12d24b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c558f47-8be1-4791-817d-0408eec25bca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d8953bd-08e7-4eb8-9286-cc548a799c5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4eeca808-9b12-4da8-b7cc-d194c322c9f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51d07665-5a93-4ff9-bf33-9bb6f6da3f66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5551552b-d765-4033-a0af-6b47fdccd74a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55534134-af6f-4352-ba78-f897c672c0c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59d7600c-b29e-4e7d-b4ee-bb46aace9b92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5aad49ea-5a3c-4c94-8cd9-d2c5a9a27960"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b1ce82d-8cc8-4860-b535-57bf3df152b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c3fd87f-5f20-4f7d-899f-248444dd19f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("612c2473-483c-498d-8c8c-244b18095758"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64e0f2f1-e1bc-447e-aa4f-07056aa3cf9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67f053ff-ca21-4da0-8e4d-20e9a7422254"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bc7e468-5e67-4ba3-9c27-b1b208c1a929"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70ce2ede-6097-4a59-a3d1-0cb75d7b92f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70df24ff-d104-4b30-94f3-7af0353020fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a76e62f-d260-4379-8543-e4601d402a78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c3ef507-240b-4200-994e-4c1e4ad88e86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e0b7863-f1d9-4a16-af33-409cc0466030"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e263a19-f6cf-4e1f-ab2c-d489c85d13b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f3cde87-0c27-4433-bea9-fc283029eba3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("807054eb-5348-4894-a6d4-7fc7f461bf18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8603d6cc-8a21-421d-b7e6-18435d819db0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88745091-439b-4979-bf3c-39e05f2c5fb3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ca8bdc9-abd4-45c5-9d67-f7e7eb1fc629"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d087737-24e0-40a9-a784-02ea1faa3678"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e7edd5b-15ce-41fa-a5d0-30d385beaea9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ff33532-13fc-4198-9c82-e995b1ddfb0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ff44e52-d948-4b36-bd6d-7f2980adbcf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91008502-aec0-4cd3-b404-67d808204bd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94dda8c4-b481-44ab-878e-ba82e5207f3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95a46c38-35a8-4a4d-9d67-5ecd83602480"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("990d5951-cca4-4637-a8df-d61fa4a389a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a3fb921-6b7d-437b-9732-0498ad40b917"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b4afd9d-38dc-4e74-a834-7c6e17cd3f87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b63d6a9-a6da-479c-aae4-599acde859cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d3d12b7-d050-48d9-b767-e93a7f8d2ab6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5dd7c06-1727-4ff7-8aad-129c67735f63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab775cba-494a-4f14-860e-40cdf6baac9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae6b963e-62a7-4561-a33d-1321fea1f58b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af8c2b79-ad3e-4cee-a20c-eef36d9a9571"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b06e7a1f-d958-4f7c-88c8-9ce85ad3c65c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b107287e-92cb-4c32-90d1-0c6aab3b1fe4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b34321ad-6124-42e7-a100-2d525bdf669e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b76ca448-2469-4a33-9c4d-2108fcb6cc29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8005fa0-e776-4442-b316-eb171503a784"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc3ccb34-e434-4619-b882-a70082f6fedc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bda5c5d4-ca5e-4208-99fe-1a84f9a91727"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf0678bb-fc54-4192-8726-b94bef1663bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfa03325-0912-4478-bad4-39b23ec390d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfcc529c-3fed-49de-913c-f2c0f38d186a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c47c61ab-37d9-4ff6-8007-c9b91d95e3ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5cb9393-5490-4eef-99e1-1e995f6ef1e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbaea109-0604-4888-bf4f-063cf4c85fcd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd29ac15-c2eb-4e84-b595-2665d8025a84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfb8b7a1-bb1c-4e26-8fb9-ddf6d46029df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0ebe003-1d23-4367-9407-9f62a250cf8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d44d890a-9631-4459-8111-0a27900f274c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d579cc70-f4be-4685-b8dc-4cedafe7d27f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df01b504-7c9f-402f-b717-7aec69434725"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6f8659b-5084-443b-a675-1da076cfdafa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e845bb34-fc20-441c-be34-89deb4d3269f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed43007b-b197-4c36-b121-366a8d99aaec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("edb75929-b348-4401-a3f0-96678dc6da69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef823fdd-dd61-472d-a81e-30dd815c1b4f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f028d28e-643a-4583-b171-50c2f3e1decb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f04ee24e-d017-451a-a3e1-8250a5bfa453"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5de8e3f-700a-4f5d-8e22-d597f1067f5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f819ff17-454a-41b4-ad34-de78157b51e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f83345eb-06c6-451a-88a1-62b1c308bda2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9ee9278-0293-45a4-bd7d-3108235ee174"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fff89fad-8c95-4ec5-9b0a-80fb1f84ec56"));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
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
        }
    }
}

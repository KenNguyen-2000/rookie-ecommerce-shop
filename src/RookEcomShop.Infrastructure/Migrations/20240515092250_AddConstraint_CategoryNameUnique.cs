using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RookEcomShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddConstraint_CategoryNameUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Categories_Name",
                table: "Categories");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Categories_Name",
                table: "Categories");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name");
        }
    }
}

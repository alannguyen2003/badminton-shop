using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCircularDependencyProductCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_ProductCategories_ProductCategoryId",
                table: "ProductCategories");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "ProductCategories",
                newName: "OfCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_ProductCategoryId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_OfCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_ProductCategories_OfCategoryId",
                table: "ProductCategories",
                column: "OfCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_ProductCategories_OfCategoryId",
                table: "ProductCategories");

            migrationBuilder.RenameColumn(
                name: "OfCategoryId",
                table: "ProductCategories",
                newName: "ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_OfCategoryId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_ProductCategories_ProductCategoryId",
                table: "ProductCategories",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id");
        }
    }
}

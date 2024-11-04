using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ioniță_Maria_Isabela_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class new1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategories_Author_AuthorID",
                table: "BookCategories");

            migrationBuilder.DropIndex(
                name: "IX_BookCategories_AuthorID",
                table: "BookCategories");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "BookCategories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "BookCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_AuthorID",
                table: "BookCategories",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategories_Author_AuthorID",
                table: "BookCategories",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

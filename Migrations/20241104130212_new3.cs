using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ioniță_Maria_Isabela_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class new3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID",
                table: "BookCategories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "BookCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

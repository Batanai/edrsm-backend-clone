using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactCenter.Data.Migrations
{
    public partial class ChangeFaqCategoryToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category ",
                table: "Faq",
                newName: "Category");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Faq",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Faq",
                newName: "Category ");

            migrationBuilder.AlterColumn<int>(
                name: "Category ",
                table: "Faq",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}

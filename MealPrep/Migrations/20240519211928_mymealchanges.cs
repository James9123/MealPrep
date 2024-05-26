using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealPrep.Migrations
{
    /// <inheritdoc />
    public partial class mymealchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MyMeals",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "MyMeals",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "MyMeals",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "MyMeals");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "MyMeals");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "MyMeals");
        }
    }
}

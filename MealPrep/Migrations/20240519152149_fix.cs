using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealPrep.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyMeals_AvaliableMeals_MealId",
                table: "MyMeals");

            migrationBuilder.AlterColumn<int>(
                name: "MealId",
                table: "MyMeals",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_MyMeals_AvaliableMeals_MealId",
                table: "MyMeals",
                column: "MealId",
                principalTable: "AvaliableMeals",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyMeals_AvaliableMeals_MealId",
                table: "MyMeals");

            migrationBuilder.AlterColumn<int>(
                name: "MealId",
                table: "MyMeals",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MyMeals_AvaliableMeals_MealId",
                table: "MyMeals",
                column: "MealId",
                principalTable: "AvaliableMeals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealPrep.Migrations
{
    /// <inheritdoc />
    public partial class changedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyMeals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AvaliableMeals",
                table: "AvaliableMeals");

            migrationBuilder.RenameTable(
                name: "AvaliableMeals",
                newName: "Meal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meal",
                table: "Meal",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Meal",
                table: "Meal");

            migrationBuilder.RenameTable(
                name: "Meal",
                newName: "AvaliableMeals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AvaliableMeals",
                table: "AvaliableMeals",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MyMeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MealId = table.Column<int>(type: "INTEGER", nullable: true),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyMeals_AvaliableMeals_MealId",
                        column: x => x.MealId,
                        principalTable: "AvaliableMeals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyMeals_MealId",
                table: "MyMeals",
                column: "MealId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealPrep.Migrations
{
    /// <inheritdoc />
    public partial class mymealsdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyMeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MealId = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyMeals_AvaliableMeals_MealId",
                        column: x => x.MealId,
                        principalTable: "AvaliableMeals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyMeals_MealId",
                table: "MyMeals",
                column: "MealId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyMeals");
        }
    }
}

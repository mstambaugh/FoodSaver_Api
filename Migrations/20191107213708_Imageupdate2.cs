using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodSaverAPI.Migrations
{
    public partial class Imageupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "RecipePhoto",
                value: "https://i.imgur.com/ieg8Yau.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "RecipePhoto",
                value: "https://i.imgur.com/aGgA4HF.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "RecipePhoto",
                value: "https://i.imgur.com/aGgA4HF.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "RecipePhoto",
                value: "https://i.imgur.com/Z3nVEce.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "RecipePhoto",
                value: "https://imgur.com/a/9Gg4CsC");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "RecipePhoto",
                value: "https://imgur.com/a/axCi8Jd");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "RecipePhoto",
                value: "https://imgur.com/a/9J4Wc8A");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "RecipePhoto",
                value: "https://imgur.com/a/kmKdWV0");
        }
    }
}

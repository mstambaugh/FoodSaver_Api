using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodSaverAPI.Migrations
{
    public partial class Clone2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecipePhoto",
                table: "Recipes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "RecipePhoto",
                value: "https://imgur.com/a/Bs1ZTEm");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "RecipeName", "RecipePhoto" },
                values: new object[] { "Box Mac and Cheese Tuna Casserole", "https://imgur.com/a/hEp2HuY" });

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
                columns: new[] { "Directions", "RecipePhoto" },
                values: new object[] { "1) Add ground beef and chili seasoning/chili powder to a large skillet and cook medium-high until browned. 2) Add diced onion, bell pepper, and garlic, cooking over medium heat and stirring regularly until onion is translucent. 3) Add diced tomatoes(drained), green chiles(drained), and beans (undrained), return to a boil, and reduce heat to medium-low. Simmer for 20 minutes, stirring occasionally. 4) Season with salt and pepper to taste and serve(optional: try with additional spices, like cumin, oregano, mix in a dash of brown sugar or hot sauce, or top with sour cream and shredded cheese).", "https://imgur.com/a/9J4Wc8A" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "RecipePhoto",
                value: "https://imgur.com/a/kmKdWV0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipePhoto",
                table: "Recipes");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "RecipeName",
                value: "Mac and Cheese Tuna Casserole");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "Directions",
                value: "1) Add ground beef and chili seasoning/chili powder to a large skillet and cook medium-high until browned. 2) Add diced onion, bell pepper, and garlic, cooking over medium heat and stirring regularly until onion is translucent. 3) Add diced tomatoes(drained), green chiles(drained), and beans (undrained), return to a boil, and reduce heat to medium-low. Simmer for 20 minutes, stirring occasionally. 4) Season with salt and pepper to taste (optional: try with additional spices, like cumin, oregano, or mix in a dash of brown sugar or hot sauce).");
        }
    }
}

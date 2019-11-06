using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodSaverAPI.Migrations
{
    public partial class Update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrepTime",
                table: "Recipes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "IngredientSubstitution",
                value: "lb wheat/whole grain pasta");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8,
                column: "IngredientName",
                value: "12oz frozen broccoli");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "Directions", "NutritionInfo", "PrepTime", "RecipeTips" },
                values: new object[] { "1) Combine ground beef, onion, and garlic in a large skillet on medium heat. Stir regularly until meat is brown and vegetables are tender. 2) Stir diced tomatoes and tomato sauce into the pan. Season with salt and pepper (optional: add 1-2 teaspoons of italian seasoning, basil, or oregano) and simmer on low 3) Simmer for 1 hour on low heat, stirring occasionally. 2) With 20 minues left, bring a large pot of water to boil and cook pasta according to box instructions. 3) Drain excess liquid from saucepan, strain pasta, and serve.", "Over 20 grams of protein per serving. 10 grams of fiber per serving. Less than 10g of sugar per serving.", "Prep: 15 min Total: 1 hour and 15 min", "Refrigerate leftover sauce and pasta in separate containers for better flavor. Leftover sauce can be frozen for upwards of 2 months in sealed ziploc bags and reheated from frozen on the stovetop." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "Directions", "PrepTime", "RecipeName" },
                values: new object[] { "1) Steam bagged brocolli in microwave or in a covered pot with a steamer on the stovetop until tender. 2) Open and strain excess liquid from tuna 2) Boil macaroni according to package instructions 3) Strain macaroni and combine with steamed brocolli, cheesepacket, extra cheddar cheese, milk, and tuna. 4) Return macaroni with mixins to the microwave or pot on stovetop and heat on low until cheese is completely melted (optional: add cheese on top of mixture of other ingredients in a casserole pan and bake at 300 degrees until cheese is slightly browned). 5) Season with salt and pepper to taste (optional: try with creole seasoning or lemon pepper ", "Prep: 5 min Total: 20 min", "Speedy Mac n' Cheese Tuna Casserole" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrepTime",
                table: "Recipes");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "IngredientSubstitution",
                value: "lb wheat pasta any shape");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8,
                column: "IngredientName",
                value: "12oz frozen broccolli florets");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "Directions", "NutritionInfo", "RecipeTips" },
                values: new object[] { "1) Combine ground beef, onion, and garlic. Cook and stir until meat is brown and vegetables are tender. Drain grease.", "fiber, vitamins, minerals, hella flavor ", "How to turn this into leftovers for lunch. save the leftover half of your onion for other crap. How to store info. What you can add if you have it." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "Directions", "RecipeName" },
                values: new object[] { "1) Steam brocolli in microwave or in a covered pot with steamer on the stovetop. 2) Open and strain canned tuna 2) Boil macaroni according to package instructions, strain pasta, and combine with steamed brocolli, packaged cheese, extra cheese, milk, tuna, and salt and pepper to taste. Return to microwave or pot on stovetop and heat on low until cheese is melted.", "Tuna Mac and Cheese" });
        }
    }
}

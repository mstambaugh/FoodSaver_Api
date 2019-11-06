using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodSaverAPI.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PricePerServing",
                table: "Recipes",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "IngredientQuantity",
                table: "Ingredients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                columns: new[] { "IngredientName", "IngredientQuantity", "IngredientSubstitution" },
                values: new object[] { "lb wheat spaghetti", 2, "lb wheat pasta any shape" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2,
                columns: new[] { "IngredientName", "IngredientQuantity", "IngredientSubstitution" },
                values: new object[] { "28oz can diced tomatoes", 1, "double tomato sauce quantity" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                columns: new[] { "IngredientName", "IngredientPrice", "IngredientQuantity", "IngredientSubstitution" },
                values: new object[] { "16oz can tomato sauce", 0.60m, 1, "jar tomato-basil/marinara pasta sauce" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                columns: new[] { "IngredientName", "IngredientPrice", "IngredientQuantity", "IngredientSubstitution" },
                values: new object[] { "large onion", 0.70m, 1, "onion powder, diced vegetable" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "IngredientName", "IngredientPrice", "IngredientQuantity", "IngredientSubstitution" },
                values: new object[,]
                {
                    { 5, "cloves garlic", 0.50m, 4, "garlic powder, italian seasoning" },
                    { 6, "lb ground beef chuck 80/20", 3.00m, 1, "lb fresh or frozen ground beef/turkey/lean pork." },
                    { 7, "7-9oz box white cheddar macaroni and cheese", 0.75m, 1, "any flavor boxed macaroni and cheese" },
                    { 8, "12oz frozen broccolli florets", 1.00m, 1, "12oz steam-in-bag frozen vegetable/vegetable mixes" },
                    { 9, "7-9oz box white cheddar macaroni and cheese", 0.75m, 1, "any 7-9oz boxed macaroni and cheese" },
                    { 10, "5oz can chunk light tuna in water", 0.75m, 1, "5oz can tuna of any variety" }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "Directions", "PricePerServing", "RecipeName", "RecipeTips" },
                values: new object[] { "1) Combine ground beef, onion, and garlic. Cook and stir until meat is brown and vegetables are tender. Drain grease.", 1.00m, "Spaghetti and Beef Marinara", "How to turn this into leftovers for lunch. save the leftover half of your onion for other crap. How to store info. What you can add if you have it." });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Directions", "NutritionInfo", "PricePerServing", "RecipeName", "RecipeTips" },
                values: new object[] { 2, "1) Steam brocolli in microwave or in a covered pot with steamer on the stovetop. 2) Open and strain canned tuna 2) Boil macaroni according to package instructions, strain pasta, and combine with steamed brocolli, packaged cheese, extra cheese, milk, tuna, and salt and pepper to taste. Return to microwave or pot on stovetop and heat on low until cheese is melted.", " ", 2.25m, "Tuna Mac and Cheese", " " });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "IngredientRecipeId", "IngredientId", "RecipeId" },
                values: new object[,]
                {
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 2 },
                    { 8, 8, 2 },
                    { 9, 9, 2 },
                    { 10, 10, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "PricePerServing",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "IngredientQuantity",
                table: "Ingredients");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                columns: new[] { "IngredientName", "IngredientSubstitution" },
                values: new object[] { "1 lb wheat spaghetti", "1 lb wheat pasta any shape" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2,
                columns: new[] { "IngredientName", "IngredientSubstitution" },
                values: new object[] { "large can tomatoes", "large can tomato sauce" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                columns: new[] { "IngredientName", "IngredientPrice", "IngredientSubstitution" },
                values: new object[] { "1/2 medium onion", 0.70m, "onion powder" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                columns: new[] { "IngredientName", "IngredientPrice", "IngredientSubstitution" },
                values: new object[] { "garlic powder", 1.50m, "italian seasoning" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "Directions", "RecipeName", "RecipeTips" },
                values: new object[] { "do this, this, and this. How to store leftovers.", "Spaghetti and Marinara", "save the leftover half of your onion for other crap. How to store info. What you can add if you have it." });
        }
    }
}

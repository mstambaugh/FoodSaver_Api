using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodSaverAPI.Migrations
{
    public partial class InitialRestore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "IngredientQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9,
                columns: new[] { "IngredientName", "IngredientPrice", "IngredientSubstitution" },
                values: new object[] { "1/2 gallon 2% milk", 1.75m, "any variety of milk or non-dairy milk" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10,
                columns: new[] { "IngredientName", "IngredientPrice", "IngredientSubstitution" },
                values: new object[] { "8oz white cheddar cheese block", 3.36m, "any variety of cheddar cheese- save by avoiding pre-shredded options" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "IngredientName", "IngredientPrice", "IngredientQuantity", "IngredientSubstitution" },
                values: new object[] { 11, "5oz can chunk light tuna in water", 0.75m, 2, "5oz can tuna of any variety" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "NutritionInfo", "RecipeName", "RecipeTips" },
                values: new object[] { "Over 20 grams of protein per serving. Approx. 10 grams of fiber per serving. Less than 10g of sugar per serving.", "Spaghetti with Beef Marinara", "For an even healthier variation, trying mixing in fresh or frozen vegetables like broccoli, spinach, Refrigerate leftover sauce and pasta in separate containers for better flavor. Leftover sauce can be frozen for upwards of 2 months in sealed ziploc bags and reheated from frozen on the stovetop." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "Directions", "NutritionInfo", "PricePerServing", "RecipeName", "RecipeTips" },
                values: new object[] { "1)Boil macaroni according to package instructions. 2) While cooking macaroni, steam brocolli in microwave or covered pot with vegetable steamer on the stovetop until tender. 2) Open tuna and drain excess water from both the tuna and steamed broccoli. 3) Strain macaroni and mix in steamed brocolli, cheesepacket, 1 handful per serving of grated cheddar cheese, a splash of milk, and tuna. 4) Return this mixture to the microwave or stovetop and heat on medium,stirring frequently, until cheese is completely melted (optional: sprinkle grated cheese on top in a casserole pan and bake at 300 degrees until cheese is slightly browned). 5) Season sparingly with salt and pepper(optional: try with either creole seasoning or lemon pepper. Just make sure to add before salt, as both seasoning mixes usually contain salt).", "Over 20g of protein per serving. Less than 6g of sugar per serving. Great source of calcium and iron.", 2.28m, "Speedy Mac and Cheese Tuna Casserole", "This recipe will leave you with some leftover cheese and milk; double the recipe size to use up more of these two ingredients, or save for breakfasts and snacks. Refrigerate leftover casserole for up to four days in a sealed container." });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "IngredientRecipeId", "IngredientId", "RecipeId" },
                values: new object[] { 11, 11, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "IngredientQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9,
                columns: new[] { "IngredientName", "IngredientPrice", "IngredientSubstitution" },
                values: new object[] { "7-9oz box white cheddar macaroni and cheese", 0.75m, "any 7-9oz boxed macaroni and cheese" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10,
                columns: new[] { "IngredientName", "IngredientPrice", "IngredientSubstitution" },
                values: new object[] { "5oz can chunk light tuna in water", 0.75m, "5oz can tuna of any variety" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "NutritionInfo", "RecipeName", "RecipeTips" },
                values: new object[] { "Over 20 grams of protein per serving. 10 grams of fiber per serving. Less than 10g of sugar per serving.", "Spaghetti and Beef Marinara", "Refrigerate leftover sauce and pasta in separate containers for better flavor. Leftover sauce can be frozen for upwards of 2 months in sealed ziploc bags and reheated from frozen on the stovetop." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "Directions", "NutritionInfo", "PricePerServing", "RecipeName", "RecipeTips" },
                values: new object[] { "1) Steam bagged brocolli in microwave or in a covered pot with a steamer on the stovetop until tender. 2) Open and strain excess liquid from tuna 2) Boil macaroni according to package instructions 3) Strain macaroni and combine with steamed brocolli, cheesepacket, extra cheddar cheese, milk, and tuna. 4) Return macaroni with mixins to the microwave or pot on stovetop and heat on low until cheese is completely melted (optional: add cheese on top of mixture of other ingredients in a casserole pan and bake at 300 degrees until cheese is slightly browned). 5) Season with salt and pepper to taste (optional: try with creole seasoning or lemon pepper ", " ", 2.25m, "Speedy Mac n' Cheese Tuna Casserole", " " });
        }
    }
}

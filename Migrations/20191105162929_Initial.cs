using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodSaverAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IngredientName = table.Column<string>(nullable: true),
                    IngredientPrice = table.Column<decimal>(nullable: false),
                    IngredientSubstitution = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RecipeName = table.Column<string>(nullable: true),
                    Directions = table.Column<string>(nullable: true),
                    NutritionInfo = table.Column<string>(nullable: true),
                    RecipeTips = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                });

            migrationBuilder.CreateTable(
                name: "IngredientRecipes",
                columns: table => new
                {
                    IngredientRecipeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RecipeId = table.Column<int>(nullable: false),
                    IngredientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipes", x => x.IngredientRecipeId);
                    table.ForeignKey(
                        name: "FK_IngredientRecipes_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "IngredientName", "IngredientPrice", "IngredientSubstitution" },
                values: new object[,]
                {
                    { 1, "1 lb wheat spaghetti", 1.20m, "1 lb wheat pasta any shape" },
                    { 2, "large can tomatoes", 1.10m, "large can tomato sauce" },
                    { 3, "1/2 medium onion", 0.70m, "onion powder" },
                    { 4, "garlic powder", 1.50m, "italian seasoning" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Directions", "NutritionInfo", "RecipeName", "RecipeTips" },
                values: new object[] { 1, "do this, this, and this. How to store leftovers.", "fiber, vitamins, minerals, hella flavor ", "Spaghetti and Marinara", "save the leftover half of your onion for other crap. How to store info. What you can add if you have it." });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "IngredientRecipeId", "IngredientId", "RecipeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipes_IngredientId",
                table: "IngredientRecipes",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipes_RecipeId",
                table: "IngredientRecipes",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecipes");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}

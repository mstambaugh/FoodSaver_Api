using Microsoft.EntityFrameworkCore;

namespace FoodSaverApi.Models
{
    public class FoodSaverApiContext : DbContext
    {
        public FoodSaverApiContext(DbContextOptions<FoodSaverApiContext> options)
            : base(options)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
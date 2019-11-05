using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FoodSaverApi.Models
{
    public class FoodSaverApiFactory : IDesignTimeDbContextFactory<FoodSaverApiContext>
    {

        FoodSaverApiContext IDesignTimeDbContextFactory<FoodSaverApiContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<FoodSaverApiContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new FoodSaverApiContext(builder.Options);
        }
    }
}
using FoodNutritionWebsite.Client.Pages;
using FoodNutritionWebsite.Server.Models;
using FoodNutritionWebsite.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NuGet.Protocol;

namespace FoodNutritionWebsite.Server.Configurations.Entities
{
    public class FoodLogSeedConfiguration : IEntityTypeConfiguration<FoodLog>
    {
        public void Configure(EntityTypeBuilder<FoodLog> builder)
        {
            builder.HasData(
                new FoodLog
                {
                    Id = 1,
                    FoodLogDateTime = DateTime.Now,
                    FoodType = "Protein",
                    FoodName = "Chicken Rice"
                }
                );

        }
    }
}

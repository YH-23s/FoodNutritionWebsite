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
                    UserID = 1,
                    FoodID = 2,
                    DateUpdated = DateTime.Now,
                    Quantity = 2
                },

                new FoodLog
                {
                    Id = 2,
                    UserID = 2,
                    FoodID = 3,
                    DateUpdated = DateTime.Now,
                    Quantity = 3
                }
                );

        }
    }
}
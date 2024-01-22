using FoodNutritionWebsite.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FoodNutritionWebsite.Server.Configurations.Entities
{
    public class FoodSeedConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
            new Food
            {
                Id = 1,
                FoodName = "Horse meatball",
                FoodDescription = "Taste what it feels like to be SPEED",
                FoodCategory = "Meat",
                FoodPicture = "Placeholder for now",
                FoodCalory = "2.1kcal"
            },
            new Food
            {
                Id = 2,
                FoodName = "Banana",
                FoodDescription = "Boomerang yellow fruit",
                FoodCategory = "Fruit",
                FoodPicture = "Placeholder for now",
                FoodCalory = "0.2kcal"
            }
            );
        }

    }
}

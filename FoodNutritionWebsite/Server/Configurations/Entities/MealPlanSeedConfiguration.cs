using FoodNutritionWebsite.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodNutritionWebsite.Server.Configurations.Entities
{
    public class MealPlanSeedConfiguration : IEntityTypeConfiguration<MealPlan>
    {
        public void Configure(EntityTypeBuilder<MealPlan> builder)
        {
           builder.HasData(
            new MealPlan
            {
                Id = 1,
                MealPlanCategory = "Carnivore",
                MealPlanName = "Steak and fries",
            },
            new MealPlan
            {
                Id = 2,
                MealPlanCategory = "Vegetable",
                MealPlanName = "Grass and vegetable",
            },
            new MealPlan
            {
                Id = 3,
                MealPlanCategory = "Omnivore",
                MealPlanName = "Grass and Meat",
            }
            );
        }
    }
}

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
				StaffID = 1
			},
            new MealPlan
            {
                Id = 2,
                MealPlanCategory = "Vegetable",
                MealPlanName = "Grass and vegetable",
				StaffID = 2
			},
            new MealPlan
            {
                Id = 3,
                MealPlanCategory = "Omnivore",
                MealPlanName = "Grass and Meat",
				StaffID = 3
			}
            );
        }
    }
}

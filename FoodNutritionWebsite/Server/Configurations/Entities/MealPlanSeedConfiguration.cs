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
              MealPlanCategory = "Weight Loss",
              MealPlanName = "Low Carb Plan",
              StaffID = 1
            },
            new MealPlan
            {
                Id = 2,
                MealPlanCategory = "Muscle Gain",
                MealPlanName = "High Protein Plan",
				StaffID = 2
			},
            new MealPlan
            {
                Id = 3,
                MealPlanCategory = "Maintenance",
                MealPlanName = "Balanced Diet Plan",
				StaffID = 3
			}
            );
        }
    }
}

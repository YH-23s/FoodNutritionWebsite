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
                Image = "https://images.pexels.com/photos/2377045/pexels-photo-2377045.jpeg?cs=srgb&dl=pexels-total-shape-2377045.jpg&fm=jpg",
                StaffID = 1
            },
            new MealPlan
            {
                Id = 2,
                MealPlanCategory = "Muscle Gain",
                MealPlanName = "High Protein Plan",
                Image = "https://hips.hearstapps.com/hmg-prod/images/gettyimages-492573824-1528828970.jpg",
                StaffID = 2
			},
            new MealPlan
            {
                Id = 3,
                MealPlanCategory = "Maintenance",
                MealPlanName = "Balanced Diet Plan",
                Image = "https://detoxkitchen.co.uk/images/imager/packageimage/active-maintain/6734478/DK_ActiveMaintain_square_2a1087fcf192370ad9a14b014fe7fa80.jpg",
                StaffID = 3
			}
            );
        }
    }
}

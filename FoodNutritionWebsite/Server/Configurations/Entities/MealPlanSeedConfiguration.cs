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
                Image = "https://www.shape.com/thmb/Nti_HBKTZCavOIQkCKRJS2sx9W8=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/shutterstock_1069332170-2000-364c5bccbb1e4e2a83a0e4cfdc15723a.jpg",
                StaffID = 1
            },
            new MealPlan
            {
                Id = 2,
                MealPlanCategory = "Muscle Gain",
                MealPlanName = "High Protein Plan",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQUlSYLFD6CaQAweZSOwkmeGQI5ooZZOgdVFoAbsnH0XA&s",
                StaffID = 2
			},
            new MealPlan
            {
                Id = 3,
                MealPlanCategory = "Maintenance",
                MealPlanName = "Balanced Diet Plan",
                Image = "https://detoxkitchen.co.uk/images/imager/packageimage/active-maintain/6734478/DK_ActiveMaintain_square_2a1087fcf192370ad9a14b014fe7fa80.jpg",
                StaffID = 3
			},
            new MealPlan
            {
                Id = 4,
                MealPlanCategory = "Eco-Friendly",
                MealPlanName = "Balanced Diet Plan",
                Image = "https://images.immediate.co.uk/production/volatile/sites/30/2023/05/cropGettyImages-1457478408-77eb943.jpg?quality=90&resize=556,505",
                StaffID = 4
            }
            );
        }
    }
}

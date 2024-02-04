using FoodNutritionWebsite.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodNutritionWebsite.Server.Configurations.Entities
{
    public class SubscriptionSeedConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.HasData(
                new Subscription
                {
                    Id = 1,
                    SubscriptionName = "Growing Muscle",
                    SubscriptionPrice = 12.20,
                    MealPlanID = 2,
                    SubscriptionDescription = "This subscription plan is great for growing muscle",
                    PaymentDescription = " This plan would be valid for a month only.",
                },
                new Subscription
                {
                    Id = 2,
                    SubscriptionName = "Losing Weight",
                    SubscriptionPrice = 15.25,
                    MealPlanID = 1,
                    SubscriptionDescription = "This subscription plan is great for losing weight",
                    PaymentDescription = " This plan would be valid for a month only.",
                }
                );
        }
    }
}

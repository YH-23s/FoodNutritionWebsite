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
                    SubscriptionPrice = 12.20,
                    SubscriptionName = "Test",
                    SubscriptionDescription = "This subscription plan is used for testing",
                    PaymentDescription =" This plan would be valid for a month",
                    MealPlanID = null
                }
                );
        }
    }
}

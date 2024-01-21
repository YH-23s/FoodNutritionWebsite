using FoodNutritionWebsite.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodNutritionWebsite.Server.Configurations.Entities
{
    public class PaymentSeedConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
                new Payment
                {
                    Id = 1,
                    PaymentAmount = 12,
                    StartingDate = DateTime.UtcNow,
                    EndingDate = DateTime.UtcNow.AddMonths(1),
                    PaymentDescription = "This is the payment detail for the subscription",
                    SubscriptionID = null

                }
                );
        }
    }
}

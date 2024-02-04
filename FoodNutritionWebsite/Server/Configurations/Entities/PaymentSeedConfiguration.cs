using FoodNutritionWebsite.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
                    SubscriptionID = 1,
                    CardNum = "9010 0102 2910 8219",
                    Cvv = "010",
                    CardExp = "12/21"

                },

                new Payment
                {
                    Id = 2,
                    SubscriptionID = 2,
                    CardNum = "9010 0102 2910 8219",
                    Cvv = "017",
                    CardExp = "07/17",
                    
                    

                }
                );
        }
    }
}

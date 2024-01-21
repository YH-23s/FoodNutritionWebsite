using FoodNutritionWebsite.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodNutritionWebsite.Server.Configurations.Entities
{
    public class User_defSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    UserName = "TestingAccount",
                    UserDOB = "12/1/2001",
                    Gender = "Male",
                    UserPhoneNum = "9012 0791",
                    UserEmail = "TestingAccount@blazor.com",
                    UserPassword = "TestingAccount_password123",
                    SubscriptionID = null,
                    DateCreated = DateTime.Now,
                    CreatedBy = "seed-script"

                },

                new User
                {
                    Id = 2,
                    UserName = "TestAccount@blazor.com",
                    UserDOB = "12/1/2005",
                    Gender = "Female",
                    UserPhoneNum = "9072 0791",
                    UserEmail = "TestAccount@blazor.com",
                    UserPassword = "TestAccount_password123",
                    SubscriptionID = null,
                    DateCreated = DateTime.Now,
                    CreatedBy = "seed-script"

                }



                ) ;
        }
    }
}

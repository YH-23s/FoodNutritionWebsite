using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FoodNutritionWebsite.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    UserName = "Joshua",
                    UserDOB = DateTime.Parse("2016-05-02"),
                    Gender = "Male",
                    UserPhoneNum = 98765432,
                    UserEmail = "joshua@gmail.com",
                    UserPassword = "1111"
                });
        }
    }
}

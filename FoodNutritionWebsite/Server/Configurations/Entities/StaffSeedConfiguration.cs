using FoodNutritionWebsite.Server.Models;
using FoodNutritionWebsite.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

namespace FoodNutritionWebsite.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
            new Staff
            {
                Id = 1,
                FirstName = "Darrell",
                LastName = "Tan",
                DOB = DateTime.ParseExact("1980-01-24", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Gender = "Male",
                ContactNumber = "98765432",
                PersonalEmail = "abc@gmail.com",
                WorkEmail = "abcd@officialweb.com",
                Address = "123 Rivervale",
                Role = "Manager",
                StartDate = DateTime.ParseExact("2020-01-24", "yyyy-MM-dd", CultureInfo.InvariantCulture)
			},
            new Staff
            {
                Id = 2,
                FirstName = "Elgin",
                LastName = "Chng",
                DOB = DateTime.ParseExact("1990-02-25", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Gender = "Male",
                ContactNumber = "91827364",
                PersonalEmail = "abcde@gmail.com",
                WorkEmail = "abcdef@officialweb.com",
                Address = "485 Sengkang Streets",
                Role = "Manager",
                StartDate = DateTime.ParseExact("2021-11-26", "yyyy-MM-dd", CultureInfo.InvariantCulture)
            },
            new Staff
            {
                Id = 3,
                FirstName = "Li",
                LastName = "Wen",
                DOB = DateTime.ParseExact("1930-04-21", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Gender = "Female",
                ContactNumber = "15429857",
                PersonalEmail = "wen@gmail.com",
                WorkEmail = "wen1@officialweb.com",
                Address = "654 Lost Woods Streets",
                Role = "HR Representative",
                StartDate = DateTime.ParseExact("2019-09-21", "yyyy-MM-dd", CultureInfo.InvariantCulture)
            }
            );
        }

    }
}

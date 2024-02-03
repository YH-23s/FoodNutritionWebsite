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
                DOB = DateTime.ParseExact("24-01-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                Gender = "Male",
                ContactNumber = "98765432",
                PersonalEmail = "dtan@gmail.com",
                WorkEmail = "dtan1@officialweb.com",
                Address = "123 Rivervale",
                Role = "Manager",
                StartDate = DateTime.ParseExact("24-01-2020", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            },
            new Staff
            {
                Id = 2,
                FirstName = "Elgin",
                LastName = "Chng",
                DOB = DateTime.ParseExact("25-02-1990", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                Gender = "Male",
                ContactNumber = "91827364",
                PersonalEmail = "chng@gmail.com",
                WorkEmail = "chng1@officialweb.com",
                Address = "485 Sengkang Streets",
                Role = "Manager",
                StartDate = DateTime.ParseExact("26-11-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            },
            new Staff
            {
                Id = 3,
                FirstName = "Li",
                LastName = "Wen",
                DOB = DateTime.ParseExact("21-04-1930", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                Gender = "Female",
                ContactNumber = "15429857",
                PersonalEmail = "wen@gmail.com",
                WorkEmail = "wen1@officialweb.com",
                Address = "654 Lost Woods Streets",
                Role = "HR Representative",
                StartDate = DateTime.ParseExact("21-09-2019", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            },
            new Staff
            {
                Id = 4,
                FirstName = "Wen",
                LastName = "Hui",
                DOB = DateTime.ParseExact("21-04-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                Gender = "Female",
                ContactNumber = "92384761",
                PersonalEmail = "hui@gmail.com",
                WorkEmail = "hui@officialweb.com",
                Address = "654 Lost Woods Streets",
                Role = "HR Representative",
                StartDate = DateTime.ParseExact("21-09-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            }
            );
        }

    }
}

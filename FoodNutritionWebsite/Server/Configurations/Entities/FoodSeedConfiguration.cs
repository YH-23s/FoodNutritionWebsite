using FoodNutritionWebsite.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FoodNutritionWebsite.Server.Configurations.Entities
{
    public class FoodSeedConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
            new Food
            {
                Id = 1,
                FoodName = "Meatball",
                FoodDescription = "Savory ground beef meatballs seasoned with herbs and simmered in a rich tomato sauce",
                FoodCategory = "Meat",
                FoodPicture = "https://www.budgetbytes.com/wp-content/uploads/2022/01/Easy-Homemade-Meatballs-spoon.jpg",
                FoodCalory = "(per meatball) 0.2kcal"
            },
            new Food
            {
                Id = 2,
                FoodName = "Banana",
                FoodDescription = "Ripe, sweet banana, high in potassium and perfect as a quick snack or for baking",
                FoodCategory = "Fruit",
                FoodPicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/Banana-Single.jpg/2324px-Banana-Single.jpg",
                FoodCalory = "0.089kcal"
            },
            new Food
            {
                Id = 3,
                FoodName = "Caesar Salad",
                FoodDescription = "A classic green salad featuring crisp romaine lettuce, creamy Caesar dressing, and crunchy croutons",
                FoodCategory = "Salad",
                FoodPicture = "https://www.seriouseats.com/thmb/Fi_FEyVa3_-_uzfXh6OdLrzal2M=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/the-best-caesar-salad-recipe-06-40e70f549ba2489db09355abd62f79a9.jpg",
                FoodCalory = "(No meat) 0.48kcal"
            },
            new Food
            {
                Id = 4,
                FoodName = "Grilled Salmon",
                FoodDescription = "A succulent piece of salmon fillet grilled to perfection, rich in Omega-3 fatty acids",
                FoodCategory = "Fish",
                FoodPicture = "https://www.seriouseats.com/thmb/p5EoDZwxr2hB99YSmQbRCkOwQJA=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/__opt__aboutcom__coeus__resources__content_migration__serious_eats__seriouseats.com__2019__07__20190620-grilled-salmon-vicky-wasik-8-3f31d8d22d66456189d3a57c9911a710.jpg",
                FoodCalory = "2.5kcal"
            }
            );

        }

    }
}

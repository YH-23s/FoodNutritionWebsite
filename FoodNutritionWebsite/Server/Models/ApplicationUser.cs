using Microsoft.AspNetCore.Identity;

namespace FoodNutritionWebsite.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public String? FirstName { get; set; }
        public String? SecondName { get; set; }
        public string LastName { get; internal set; }
    }
}
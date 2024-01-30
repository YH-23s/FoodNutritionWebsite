using Microsoft.AspNetCore.Identity;

namespace FoodNutritionWebsite.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; internal set; }
        public string? Gender { get; set; }

    }
}
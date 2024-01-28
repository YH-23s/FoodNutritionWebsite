using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    public class Food : BaseDomainModel
    {
        [Required(ErrorMessage = "Food Name is required")]
        public string? FoodName { get; set; }

        [Required(ErrorMessage = "Food Description is required")]
        public string? FoodDescription { get; set;}

        [Required(ErrorMessage = "Food Category is required")]
        public string? FoodCategory { get; set;}

        [Required(ErrorMessage = "Food Picture is required")]
        public string? FoodPicture { get; set;}

        [Required]
        [RegularExpression(@".*kcal$", ErrorMessage = "Food Calory must end with 'kcal'")]
        public string? FoodCalory { get; set;}
    }
}

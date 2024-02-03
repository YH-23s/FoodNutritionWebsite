using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    public class MealPlan : BaseDomainModel
    {
        [Required(ErrorMessage = "Meal Plan Categroy is required")]
        public string? MealPlanCategory { get; set; }
        [Required(ErrorMessage = "Meal Plan Name is required")]
        public string? MealPlanName { get; set; }

        public string? Image {  get; set; }

        [Required(ErrorMessage = "Staff is required")]
        public int StaffID { get; set; }
        public virtual Staff? Staff { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    public class MealPlan : BaseDomainModel
    {
        public string? MealPlanCategory { get; set; }
        public string? MealPlanName { get; set; }
        public int StaffID { get; set; }
        public virtual Staff? Staff { get; set; }
    }
}

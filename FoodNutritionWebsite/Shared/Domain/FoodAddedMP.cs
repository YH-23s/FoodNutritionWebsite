using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    internal class FoodAddedMP : BaseDomainModel
    {
        public int FoodID { get; set; }
        public virtual Food? Food { get; set; }
        public int MealPlanID { get; set; }
        public virtual MealPlan? MealPlan { get; set; }
    }
}

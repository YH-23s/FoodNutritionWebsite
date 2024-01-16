using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    internal class AddNutrition : BaseDomainModel
    {
        public int Value { get; set; }
        public int FoodID { get; set; }
        public virtual Food? Food { get; set; }
        public int FoodNutritionID { get; set; }
        public virtual FoodNutrition? FoodNutrition { get; set; }
    }
}

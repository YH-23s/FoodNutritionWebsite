using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    internal class FoodNutrition : BaseDomainModel
    {
        public string? FoodNutriName { get; set; }
        public string? FoodNutriDescription { get; set; }
        public string? FoodNutriCategory {  get; set; }
    }
}

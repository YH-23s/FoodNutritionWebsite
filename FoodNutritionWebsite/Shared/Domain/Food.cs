using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    internal class Food : BaseDomainModel
    {
        public string? FoodName { get; set; }
        public string? FoodDescription { get; set;}
        public string? FoodCategory { get; set;}
        public string? FoodPicture { get; set;}
        public string? FoodCalory { get; set;}
    }
}

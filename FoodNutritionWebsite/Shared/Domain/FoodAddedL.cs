using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    public class FoodAddedL : BaseDomainModel
    {
        public int FoodQty { get; set; }
        public int FoodID { get; set; }
        public virtual Food? Food { get; set; }
        public int FoodLogID { get; set; }
        public virtual FoodLog? FoodLog { get; set; }
    }
}
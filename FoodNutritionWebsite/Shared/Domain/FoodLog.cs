using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    public class FoodLog : BaseDomainModel
    {
        public double Quantity { get; set; }
        public DateTime? FoodLogDateTime { get; set; }
        public string? FoodType { get; set; }

        public string? FoodName { get; set; }
        public int? UserID { get; set; }
        public virtual User? User { get; set; }
        public int? FoodID { get; set; }
        public virtual Food? Food { get; set; }
    }
}
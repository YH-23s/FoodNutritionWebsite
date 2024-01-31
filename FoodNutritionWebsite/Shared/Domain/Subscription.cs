using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    public class Subscription : BaseDomainModel
    {

        
        public double? SubscriptionPrice { get; set; }

        [Required]
        public string? SubscriptionName { get; set; }

        [Required]
        public string? SubscriptionDescription { get; set; }

        public string? PaymentDescription { get; set; }

        public int? MealPlanID { get; set; }
        public virtual MealPlan? MealPlan { get; set; }

    }
}

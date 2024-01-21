using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    public class Subscription : BaseDomainModel
    {
        public int SubscriptionPrice { get; set; }
        public string? SubscriptionName { get; set; }
        public string? SubscriptionDescription { get; set; }
        public string? PaymentDescription { get; set; }
        public int? MealPlanID { get; set; }
        public virtual MealPlan? MealPlan { get; set; }

    }
}

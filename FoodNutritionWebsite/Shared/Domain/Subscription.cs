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

        [Required(ErrorMessage = "Subscription price is required")]
        [DataType(DataType.Currency, ErrorMessage = "Subscription price is required, please enter a valid subscription price")]
        public double? SubscriptionPrice { get; set; }

        [Required(ErrorMessage = "Subscription name is required")]
        [StringLength(255, ErrorMessage = "Subscription name must be between 1 and 255 characters", MinimumLength = 1)]
        public string? SubscriptionName { get; set; }

        [Required(ErrorMessage = "Subscription description is required")]
        [StringLength(500, ErrorMessage = "Subscription description must be between 1 and 500 characters", MinimumLength = 1)]
        public string? SubscriptionDescription { get; set; }

        [Required(ErrorMessage = "Payment Description is required")]
        [StringLength(255, ErrorMessage = "Payment Description must be between 1 and 255 characters", MinimumLength = 1)]
        public string? PaymentDescription { get; set; }

        public int? MealPlanID { get; set; }
        public virtual MealPlan? MealPlan { get; set; }

    }
}

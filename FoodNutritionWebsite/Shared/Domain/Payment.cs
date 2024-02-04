using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace FoodNutritionWebsite.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        [Required(ErrorMessage = "CVV is required")]
        public string? Cvv { get; set; }

        [Required(ErrorMessage = "Card expiration date is required")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/\d{2}$", ErrorMessage = "Invalid card expiration date")]
        public string? CardExp { get; set; }

        [Required(ErrorMessage = "Card number is required")]
        [CreditCard(ErrorMessage = "Invalid credit card number")]
        public string? CardNum { get; set; }


        
        public double? PaymentAmount { get; set; }

        
        public DateTime? StartingDate { get; set; }

        public DateTime? EndingDate { get; set; }

        public string? PaymentDescription { get; set; }

        public string? SubscriptionPlanName { get; set; }

        
        public int? SubscriptionID { get; set; }
        public virtual Subscription? Subscription { get; set; }

      

    }
}

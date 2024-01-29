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
   
        public double PaymentAmount { get; set; }

        public DateTime StartingDate { get; set; }


        public DateTime EndingDate { get; set; }


        public string? PaymentDescription { get; set; }


        public string? SubscriptionPlanName { get; set; }

        
        public int? SubscriptionID { get; set; }
        public virtual Subscription? Subscription { get; set; }

    }
}

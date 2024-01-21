using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public int PaymentAmount { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string? PaymentDescription { get; set; }
        public int? SubscriptionID { get; set; }
        public virtual Subscription? Subscription { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    public class User : BaseDomainModel
    {
        public string? UserName { get; set; }
        public DateTime? UserDOB { get; set; }
        public string? Gender { get; set; }
        public string? UserPhoneNum { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPassword { get; set; }
        public int SubscriptionID { get; set; }
        public virtual Subscription? Subscription { get; set; }
    }

}

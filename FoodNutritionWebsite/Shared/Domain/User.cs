using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    public class User : BaseDomainModel
    {
        
        public string? UserName { get; set; }


        
        public String? UserDOB { get; set; }


        public string? Gender { get; set; }


        
        public string? UserPhoneNum { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
        ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        
        public string UserPassword { get; set; }

        public int? SubscriptionID { get; set; }
        public virtual Subscription? Subscription { get; set; }

        
    }

}

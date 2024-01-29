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
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]{3,}$", ErrorMessage = "UserName must be alphanumeric and have a minimum length of 3 characters.")]
        public string? UserName { get; set; }


        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^\d{1,2}/\d{1,2}/\d{4}$", ErrorMessage = "Please enter a valid date in MM/dd/yyyy format")]
        public String? UserDOB { get; set; }


        public string? Gender { get; set; }


        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "The Contact Number entered is not correct.")]
        public string? UserPhoneNum { get; set; }


        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid Email address")]
        public string? UserEmail { get; set; }

        [Required]
        public string? UserPassword { get; set; }
        public int? SubscriptionID { get; set; }
        public virtual Subscription? Subscription { get; set; }

        
    }

}

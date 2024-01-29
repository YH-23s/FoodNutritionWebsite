using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required(ErrorMessage = "First alphabet must be a capital letter")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Date Of Birth is required")]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string? Gender { get; set; }

        [Required]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number")]
        public string? ContactNumber { get; set; }

        [Required(ErrorMessage = "Personal Email is required")]
        public string? PersonalEmail { get; set; }

        [Required(ErrorMessage = "Work Email is required")]
        public string? WorkEmail { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string? Role { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        public DateTime? StartDate { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using ASPDOTNETCoreBasics.Attribute;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPDOTNETCoreBasics.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter ConfirmPassword")]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't match")]
        public string ConfirmPassword { get; set; }

        [RegularExpression("^[6789]\\d{9}$", ErrorMessage = "Please Enter Correct Contact No.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please Enter Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please Enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Select Gender")]
        public string Gender { get; set; }
        
        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool Terms { get; set; }
    }
}



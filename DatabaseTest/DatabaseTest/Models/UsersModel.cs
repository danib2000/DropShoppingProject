using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseTest.Models
{
    public class UsersModel
    {
        [Display(Name = "User ID")]
        public int UserId { get; set; }
        
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Please enter a userName")]
        public String UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter an Email address")]
        public String EmailAddress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage = "Email and Confirm Email must match!")]
        public String ConfirmEmail { get; set; }

        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must enter a password")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "You need to provide a long enough password ")]
        public String Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match!")]
        public String ConfirmPassword { get; set; }
    }
}
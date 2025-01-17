using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotations.Models
{
    public class Employee
    {
        [Required (ErrorMessage = "Id is Mandatory")]
        public int Id { get; set; }

        [StringLength(10,MinimumLength = 5, ErrorMessage = "Length of Name should be in between 5 & 20")]
        [Required(ErrorMessage = "Name is Mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is Mandatory")]
        [Range(0,120,ErrorMessage ="Age should be in range 0-120")]
        public int? Age { get; set; }        
        [Required(ErrorMessage = "Gender is Mandatory")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Email is Mandatory")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$",ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Mandatory")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$""", ErrorMessage = "Uppercase, Lowercase, Numbers, Symbols, 8 Characters")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirm Password is Mandatory")]
        [Compare("Password",ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; }


    }
}
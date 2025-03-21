//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SignupWithLoginMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string firstName { get; set; }
        
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string lastName { get; set; }
        
        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required")]
        public string gender { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is required")]
        public int age { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address.")]
        public string email { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is required")]
        public string username { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("password",ErrorMessage = "Password do not match")]
        public string confirm_password { get; set; }
    }
}

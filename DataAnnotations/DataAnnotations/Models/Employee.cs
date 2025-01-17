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
        [Required(ErrorMessage = "Name is Mandatory")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is Mandatory")]
        public int? Age { get; set; }        
        [Required(ErrorMessage = "Gender is Mandatory")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Email is Mandatory")]
        public string Email { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodNStuffMVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [Display(Name ="First Human Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Human Name")]
        public string LastName { get; set; }

        //public string FullName => return $"{FirstName} {LastName}"; (<--THIS DOES THE SAME THING AS VVVV)
        [Display(Name ="Full Human Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
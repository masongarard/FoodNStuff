﻿using System;
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
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        //public string FullName => return $"{FirstName} {LastName}"; (<--THIS DOES THE SAME THING AS VVVV)
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
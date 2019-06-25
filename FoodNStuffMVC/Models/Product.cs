﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodNStuffMVC.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name="Number In Stock")]
        public int InventoryCount { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Display(Name ="Do humans generally consider it food?")]
        public bool IsFood { get; set; }
    }
}
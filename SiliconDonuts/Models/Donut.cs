﻿using System;
using System.ComponentModel.DataAnnotations;
namespace SiliconDonuts.Models
{
    public class Donut
    {
        [Key]
        public int DonutId { get; set; }

        [Required]
        public decimal DonutPrice { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Allergies { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        
        public bool DonutOfTheDay { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace P01_SalesDatabase.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Name { get; set; }

        public double Sales { get; set; } 
    }
}
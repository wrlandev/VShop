﻿using System.ComponentModel.DataAnnotations;
using VShop.API.Models;

namespace VShop.API.DTOs
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(80)]
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Api.Dtos
{
    public class UpdateUserDto
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}

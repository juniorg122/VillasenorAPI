using System;
using System.ComponentModel.DataAnnotations;

namespace VillasenorAPI.Dtos.CustomerDtos
{
    public class CustomerCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool IsValid { get; set; }
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }
}
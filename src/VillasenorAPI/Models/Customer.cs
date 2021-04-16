using System;
using System.ComponentModel.DataAnnotations;

namespace VillasenorAPI.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int Id { get; set; }
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
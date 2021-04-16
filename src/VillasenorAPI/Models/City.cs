using System.ComponentModel.DataAnnotations;

namespace VillasenorAPI.Models
{
    public class City
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int CityCode { get; set; }
        [Required]
        public string CityNamae { get; set; }
    }
}
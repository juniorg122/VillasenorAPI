using System.ComponentModel.DataAnnotations;

namespace VillasenorAPI.Dtos
{
    public class CityUpdateDto
    {
        [Required]
        public int CityCode { get; set; }
        [Required]
        public string CityName { get; set; }
    }
}
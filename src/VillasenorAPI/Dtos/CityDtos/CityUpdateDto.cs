using System.ComponentModel.DataAnnotations;

namespace VillasenorAPI.Dtos.CityDtos
{
    public class CityUpdateDto
    {
        [Required]
        public int CityCode { get; set; }
        [Required]
        public string CityName { get; set; }
    }
}
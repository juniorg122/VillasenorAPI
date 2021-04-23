using System.ComponentModel.DataAnnotations;

namespace VillasenorAPI.Dtos.CityDtos
{
    public class CityCreateDto
    {
        [Required]
        public int CityCode { get; set; }
        [Required]
        public string CityName { get; set; }
    }
}
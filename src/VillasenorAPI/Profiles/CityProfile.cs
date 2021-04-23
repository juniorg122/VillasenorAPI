using AutoMapper ; 
using VillasenorAPI.Dtos  ;
using VillasenorAPI.Models ; 

namespace VillasenorAPI.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City , CityReadDto>();
            CreateMap<CityCreateDto , City>();
            CreateMap<CityUpdateDto , City>();
            CreateMap<City , CityUpdateDto>();
        }
    }
}
using AutoMapper;
using VillasenorAPI.Dtos;
using VillasenorAPI.Models;

namespace VillasenorAPI.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer , CustomerReadDto>();
        }
    }
}
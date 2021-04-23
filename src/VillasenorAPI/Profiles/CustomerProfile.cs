using AutoMapper;
using VillasenorAPI.Dtos;
using VillasenorAPI.Dtos.CustomerDtos.BuyingCustomerDtos;
using VillasenorAPI.Dtos.CustomerDtos.SellingCustomerDtos;
using VillasenorAPI.Models;

namespace VillasenorAPI.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer , CustomerReadDto>();
            CreateMap<SellingCustomer , SellingCustomerReadDto>();
            CreateMap<BuyingCustomer , BuyingCustomerReadDto>();
            CreateMap<SellingCustomerCreateDto , SellingCustomer>();
            CreateMap<BuyingCustomerCreateDto , BuyingCustomer>();
        }
    }
}
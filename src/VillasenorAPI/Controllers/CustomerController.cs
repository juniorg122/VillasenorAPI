using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VillasenorAPI.Data;
using VillasenorAPI.Dtos;
using VillasenorAPI.Models;

namespace VillasenorAPI.AddControllers
{
    [Route("api/customer")]
    
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //
        private readonly ICustomerAPIRepo _repo;
        private readonly IMapper _mapper;

        //Dependency Injection Constructor
        public CustomerController(ICustomerAPIRepo repo , IMapper mapper )
        {
            _repo = repo ; 
            _mapper = mapper ; 
        }
    [HttpGet]
    public ActionResult<IEnumerable<CustomerReadDto>> GetAllCustomers()
    {
        var customer = _repo.GetAllCustomers();
        var sellingcustomer = _repo.GetAllSellingCustomers();
        return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customer));
    }
    
    [HttpGet("selling")]
    public ActionResult <IEnumerable<CustomerReadDto>> GetAllSellingCustomers( )
    {
        var sellingcustomer = _repo.GetAllSellingCustomers();
        return Ok(_mapper.Map<IEnumerable<SellingCustomerReadDto>>(sellingcustomer));
    }
    [HttpGet("buying")]
    public ActionResult<IEnumerable<CustomerReadDto>> GetAllBuyingCustomers()
    {
        var buyingCustomer = _repo.GetAllBuyingCustomers();
        return Ok(_mapper.Map<IEnumerable<BuyingCustomerReadDto>>(buyingCustomer));
    }

    [HttpGet("{id}")]
    public ActionResult<CustomerReadDto> GetCustomerbyId(int id)
    {
        var customer = _repo.GetCustomerbyId(id);
       
        return Ok (_mapper.Map<CustomerReadDto>(customer));
    }

    

    }
}
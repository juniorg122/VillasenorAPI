using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VillasenorAPI.Data;
using VillasenorAPI.Dtos;

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

    public ActionResult<IEnumerable<CustomerReadDto>> GetAllCustomers()
    {
        var customers = _repo.GetAllCustomers();
        return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customers));
    }

    public ActionResult<CustomerReadDto> GetCustomerbyId(int id)
    {
        var city = _repo.GetCustomerbyId(id);
        return Ok (_mapper.Map<CustomerReadDto>(city));
    }

    }
}
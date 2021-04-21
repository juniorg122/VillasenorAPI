using Microsoft.AspNetCore.Mvc;
using VillasenorAPI.Data;

namespace VillasenorAPI.AddControllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //
        private readonly ICustomerAPIRepo _repo;
        //Dependency Injection Constructor
        public CustomerController(ICustomerAPIRepo repo)
        {
            _repo = repo ; 
        }


    }
}
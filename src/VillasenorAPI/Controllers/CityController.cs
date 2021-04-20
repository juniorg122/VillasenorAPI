using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VillasenorAPI.Data;
using VillasenorAPI.Models;

namespace VillasenorAPI.Controllers 
{
    [Route("api/city")]
    [ApiController]
    public class CityController: ControllerBase
    {
        private readonly ICityAPIRepo _repo;

        public CityController(ICityAPIRepo repo)
        {
            _repo = repo ; 
        }
    [HttpGet]
        public ActionResult <IEnumerable<City>> GetAllCities()
        {
            var cities = _repo.GetAllCities();
            return Ok(cities);
        }
    [HttpGet("{id}")]
        public ActionResult<City> GetCityById(int id )
        {
            var city = _repo.GetCityById(id);
            //Check if city is null 
            if (city == null)
            {
                return NotFound(); 
            }
            return Ok(city);
        }
    }
}
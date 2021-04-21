using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VillasenorAPI.Data;
using VillasenorAPI.Models;
using AutoMapper ; 
using VillasenorAPI.Dtos ; 

namespace VillasenorAPI.Controllers 
{
    [Route("api/city")]
    [ApiController]
    public class CityController: ControllerBase
    {
        private readonly ICityAPIRepo _repo;
        private readonly IMapper _mapper ; 
        public CityController(ICityAPIRepo repo , IMapper mapper)
        {
            _repo = repo ; 
            _mapper = mapper ; 
        }
    [HttpGet]
        public ActionResult <IEnumerable<CityReadDto>> GetAllCities()
        {
            var cities = _repo.GetAllCities();
            return Ok(_mapper.Map<IEnumerable<CityReadDto>>(cities));
        }
    [HttpGet("{id}")]
        public ActionResult<CityReadDto> GetCityById(int id )
        {
            var city = _repo.GetCityById(id);
            //Check if city is null 
            if (city == null)
            {
                return NotFound(); 
            }
            return Ok(_mapper.Map<CityReadDto>(city));
        }
    }
}
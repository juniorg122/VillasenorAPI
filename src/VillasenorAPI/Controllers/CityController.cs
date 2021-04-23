using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using VillasenorAPI.Models;
using AutoMapper ; 

using Microsoft.AspNetCore.JsonPatch;
using VillasenorAPI.Dtos.CityDtos;
using VillasenorAPI.Data.CityData;

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
    [HttpGet("{id}", Name="GetCityById")]
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
    [HttpPost]
        public ActionResult <CityReadDto> CreateCity(CityCreateDto citycreatdto)
        {
            var cityModel = _mapper.Map<City>(citycreatdto);
            _repo.CreateCity(cityModel);
            _repo.SaveChanges();
            var cityReadDto = _mapper.Map<CityReadDto>(cityModel);
            return CreatedAtRoute(nameof(GetCityById),new {Id = cityReadDto.Id}, cityReadDto);
        }
    [HttpPut("{id}")]
        public ActionResult UpdateCity(int id , CityUpdateDto cityUpdateDto)
        {
            var cityModelFromRepo = _repo.GetCityById(id);
            if(cityModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(cityUpdateDto , cityModelFromRepo);
            _repo.UpdateCity(cityModelFromRepo);
            _repo.SaveChanges();
            return NoContent();
        }
    [HttpPatch("{id}")]
        public ActionResult PartialCityUpdate(int id , JsonPatchDocument<CityUpdateDto> patchDoc)
        {
            var cityModelFromRepo = _repo.GetCityById(id);
            if(cityModelFromRepo == null)
            {
                return NotFound();
            }
            var cityToPatch = _mapper.Map<CityUpdateDto>(cityModelFromRepo);
            patchDoc.ApplyTo(cityToPatch , ModelState);
            if(!TryValidateModel(cityToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(cityToPatch,cityModelFromRepo);
            _repo.UpdateCity(cityModelFromRepo);
            _repo.SaveChanges();
            return NoContent();
        }
[HttpDelete("{id}")]
        public ActionResult DeleteCity(int id )
        {
            var cityModelFromRepo = _repo.GetCityById(id);
            if(cityModelFromRepo == null)
            {
                return NotFound();
            }
            _repo.DeleteCity(cityModelFromRepo);
            _repo.SaveChanges();
            return NoContent();
        }
    }
}
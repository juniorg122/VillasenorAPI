using System.Collections.Generic;
using VillasenorAPI.Models;

namespace VillasenorAPI.Data
{
    public class MockCityAPIRepo : ICityAPIRepo
    {
        public void CreateCity(City city)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCity(City city)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<City> GetAllCities()
        {
            var cities = new List <City>
            {
                new City{Id= 0 , CityCode = 1000 , CityName = "Los Angeles"},
                new City{Id=1 , CityCode = 1001, CityName = "San Fernando"},
                new City{Id = 3 , CityCode = 6 , CityName = "Pacoima"}
            };

            return cities ; 
        }

        public City GetCityById(int id)
        {
           return  new City {Id = 1 , CityCode = 1001 , CityName="San Fernando"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCity(City city)
        {
            throw new System.NotImplementedException();
        }
    }
}
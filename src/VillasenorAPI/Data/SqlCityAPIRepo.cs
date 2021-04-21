using System.Collections.Generic;
using System.Linq;
using VillasenorAPI.Models;

namespace VillasenorAPI.Data
{
    public class SqlCityAPIRepo : ICityAPIRepo
    {
        private readonly CityContext _context;

        public SqlCityAPIRepo(CityContext context)
        {
            _context = context ;
        }
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
            return _context.CityItems.ToList();
        }

        public City GetCityById(int id)
        {
            return _context.CityItems.FirstOrDefault(p=> p.Id == id);
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
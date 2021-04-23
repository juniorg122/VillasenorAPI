using System;
using System.Collections.Generic;
using System.Linq;
using VillasenorAPI.Models;

namespace VillasenorAPI.Data.CityData
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
            if(city == null)
            {
                throw new ArgumentNullException(nameof(city));
            }
            _context.CityItems.Add(city);
        }

        public void DeleteCity(City city)
        {
            if(city == null)
            {
                throw new ArgumentNullException(nameof(city));

            }
            _context.CityItems.Remove(city);
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
            return (_context.SaveChanges() >= 0 );
        }

        public void UpdateCity(City city)
        {
            
        }
    }
}
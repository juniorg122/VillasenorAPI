using System.Collections.Generic;
using VillasenorAPI.Models;

namespace VillasenorAPI.Data.CityData
{
public interface ICityAPIRepo
{
    bool SaveChanges();

    IEnumerable<City> GetAllCities();

    City GetCityById(int id);

    void CreateCity(City city);
    void UpdateCity(City city);
    void DeleteCity(City city);

    

}
}
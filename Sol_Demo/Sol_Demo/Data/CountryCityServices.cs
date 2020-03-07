using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Data
{
    public class CountryCityServices
    {
        public async Task<IEnumerable<CountryModel>> GetCountryDataAsync()
        {
            return await Task.Run(() =>
            {
                var countryList = new List<CountryModel>();

                countryList.Add(new CountryModel() { CountryId = 1, CountryName = "India" });
                countryList.Add(new CountryModel() { CountryId = 2, CountryName = "Japan" });

                return countryList;
            });
        }

        public async Task<IEnumerable<CityModel>> GetCityDataAsync()
        {
            return await Task.Run(() =>
            {
                var cityList = new List<CityModel>();

                cityList.Add(new CityModel() { CityId = 1, CityName = "Mumbai", CountryId = 1 });
                cityList.Add(new CityModel() { CityId = 2, CityName = "Delhi", CountryId = 1 });
                cityList.Add(new CityModel() { CityId = 3, CityName = "Tokyo", CountryId = 2 });
                cityList.Add(new CityModel() { CityId = 4, CityName = "Kobe", CountryId = 2 });

                return cityList;
            });
        }
    }
}
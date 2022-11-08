using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace CityInfo.API.Controller
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == id);

            return Ok(city);
        }

        [HttpPost]
        public IActionResult CreateCity([FromBody] CityForCreationDto cit)
        {
            var maxCitiId = CitiesDataStore.Current.Cities.Max(p => p.Id);

            var CityDto = new CityDto()
            {
                Id = maxCitiId + 1,
                Name = cit.Name,
                Description = cit.Description,
            };
            CitiesDataStore.Current.Cities.Add(CityDto);

            return CreatedAtRoute(
                "GetCities", new { id = CityDto.Id }, CityDto);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateCity(int cityId, [FromBody] CityForUpdateDto cit)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }
            city.Name = cit.Name;
            city.Description = cit.Description;

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCity(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }

            CitiesDataStore.Current.Cities.Remove(city);

            return NoContent();
        }
    }
}
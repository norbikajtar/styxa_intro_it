﻿using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CityInfo.API.Controller
{
    [ApiController]
    [Route("api/cities/{cityId}/pointsofinterest")]
    public class PointsOfInterestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{id}", Name = "GetPointOfInterest")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }

            return Ok(city.PointsOfInterest.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public IActionResult CreatePointOfInterest(int cityId, [FromBody] PointOfInterestForCreationDto poi)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }

            var maxPointOfInterestId = CitiesDataStore.Current.Cities.SelectMany(
                             c => c.PointsOfInterest).Max(p => p.Id);

            var pointOfInterestDto = new PointOfInterestDto()
            {
                Id = maxPointOfInterestId + 1,
                Name = poi.Name,
                Description = poi.Description
            };

            city.PointsOfInterest.Add(pointOfInterestDto);


            return CreatedAtRoute(
                "GetPointOfInterest",
                new { cityId, id = pointOfInterestDto.Id },
                pointOfInterestDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePointOfInterest(int cityId, int id, [FromBody] PointOfInterestForUpdateDto poi)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }

            var pointOfInterest = city.PointsOfInterest.FirstOrDefault(x => x.Id == id);

            if (pointOfInterest == null)
            {
                return BadRequest();
            }

            pointOfInterest.Name = poi.Name;
            pointOfInterest.Description = poi.Description;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePointOfInterest(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }

            var pointOfInterest = city.PointsOfInterest.FirstOrDefault(x => x.Id == id);

            if (pointOfInterest == null)
            {
                return BadRequest();
            }

            city.PointsOfInterest.Remove(pointOfInterest);

            return NoContent();
        }
    }
}
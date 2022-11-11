using AutoMapper;
using CityInfo.API.Contexts;
using CityInfo.API.Entities;
using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace CityInfo.API.Controller
{
  [ApiController]
  [Route("api/cities")]
  public class CitiesController : ControllerBase
  {
    private readonly CityInfoContext _ctx;
    private readonly IMapper _mapper;

    public CitiesController(CityInfoContext ctx, IMapper mapper)
    {
      _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
      _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public IActionResult GetCities()
    {
      return Ok(_mapper.Map<IEnumerable<CityDto>>(_ctx.Cities));
    }

    [HttpGet("{id}")]
    public IActionResult GetCity(int id)
    {
      var city = _mapper.Map<CityDto>(_ctx.Cities.FirstOrDefault(x => x.Id == id));

      return Ok(city);
    }

    [HttpPost]
    public IActionResult CreateCity([FromBody] CityForCreationDto cit)
    {

      var city = _mapper.Map<City>(cit);

      _ctx.Cities.Add(city);

      _ctx.SaveChanges();

      return CreatedAtRoute(
          "GetCities", new { id = city.Id }, city);
    }
    [HttpPut("{cityId}")]
    public IActionResult UpdateCity(int cityId, [FromBody] CityForUpdateDto cit)
    {
      var city = _ctx.Cities.FirstOrDefault(x => x.Id == cityId);

      if (city == null)
      {
        return BadRequest();
      }

      _mapper.Map(cit, city);

      _ctx.SaveChanges();

      return NoContent();
    }
    [HttpDelete("{cityId}")]
    public IActionResult DeleteCity(int cityId)
    {
      var city = _ctx.Cities.FirstOrDefault(x => x.Id == cityId);

      if (city == null)
      {
        return BadRequest();
      }

      _ctx.Remove(city);

      _ctx.SaveChanges();

      return NoContent();
    }
  }
}
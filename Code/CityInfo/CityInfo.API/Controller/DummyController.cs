using CityInfo.API.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CityInfo.API.Controller
{
  [ApiController]
  [Route("api/testdatabase")]
  public class DummyController : ControllerBase
  {
    private readonly CityInfoContext _ctx;

    public DummyController(CityInfoContext ctx)
    {
      _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
    }

    [HttpGet]
    public IActionResult TestDatabase()
    {
      return Ok(_ctx.Cities);
    }

    [HttpGet("{id}")]

    public IActionResult TestPrime(int id)
    {
      if (id == 1)
      {
        return Ok("The number you provided is not a prime number.");
      }
      else
      {
        if (id == 2)
          return Ok("The number you provided is a prime number.");
      }

      for (int i = 3; i < id; i++)
      {
        if (id % i == 0)
          return Ok("The number you provided is nor a prime number");
        else
          return Ok("The number you provided is a prime number");
      }
      return Ok();
    }

  }
}
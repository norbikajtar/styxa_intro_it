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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
      [HttpGet]
      public async Task<ActionResult<List<SuperHero>>> GetSuperHeros()
      {
      return new List<SuperHero>
      {
        new SuperHero
        {
          Name = "Spiderman",
          LastName = "Parker",
          FirstName = "Peter",
          Place = "NYC",

        }
      };
    }
    }
}

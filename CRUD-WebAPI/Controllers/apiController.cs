using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class apiController : ControllerBase
    {
        //to have access from everywhere
        private static List<SuperHero> heroes = new List<SuperHero>
            {
                new SuperHero {
                        Id = 1,
                        Name="Storm",
                        FirstName="Marcelle",
                        LastName="Mendes",
                        Place="New York"
                }
            };

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            
            return Ok(heroes);

        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHeoro(SuperHero hero)
        {
            heroes.Add(hero);
            return Ok(heroes);

        }
    }
}

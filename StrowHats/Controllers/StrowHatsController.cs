using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrowHats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StrowHatsController : ControllerBase
    {
        private static List<StrowHats> strowHats = new List<StrowHats>
        {
            new StrowHats
            {
            Id = 1,
            FirstName = "Luffy",
            LastName = "Monkey D",
            PlaceOfBirth = "EastBlue",
            Responsibility = "Captain"
            },
            new StrowHats
            {
            Id = 2,
            FirstName = "Zorro",
            LastName = "Rorono",
            PlaceOfBirth = "EastBlue",
            Responsibility = "SwordMan"
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<StrowHats>>> Get()
        {
            return Ok(strowHats);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StrowHats>> Get(int id)
        {
            var strowHat = strowHats.Find(h => h.Id == id);
            if (strowHat == null)
            {
                return BadRequest("strowHat doest found");
            }
            return Ok(strowHat);
        }

        [HttpPost]
        public async Task<ActionResult<List<StrowHats>>> Post(StrowHats newStrowHat)
        {
            strowHats.Add(newStrowHat);
            return Ok(strowHats);
        }

        [HttpPut]
        public async Task<ActionResult<List<StrowHats>>> PATCH(StrowHats request)
        {
            var strowHat = strowHats.Find(h => h.Id == request.Id);
            if (strowHat == null)
            {
                return BadRequest("strowHat doest found");
            }

            strowHat.FirstName = request.FirstName;
            strowHat.LastName = request.LastName;
            strowHat.PlaceOfBirth = request.PlaceOfBirth;
            strowHat.Responsibility = request.Responsibility;
            return Ok(strowHat);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<StrowHats>>> Delete(int id)
        {
            var strowHat = strowHats.Find(h => h.Id == id);
            if (strowHat == null)
                return BadRequest("strowHat doest found");
            strowHats.Remove(strowHat);
            return Ok(strowHats);
        }
    }
}

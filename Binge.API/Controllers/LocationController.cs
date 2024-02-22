using Bing.Models;
using Microsoft.AspNetCore.Mvc;

namespace Binge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {

        private readonly IRepository _repo;

        public LocationController(IRepository repo)
        {
            _repo = repo;
        }

       

        [HttpGet]
        public IActionResult GetLocations()
        {
            // Define the start and end times for availability 10 am and 1 pm
            var startTime = new TimeSpan(10, 0, 0);
            var endTime = new TimeSpan(13, 0, 0); 
            return Ok(_repo.GetLocation(startTime,endTime));
        }

        [HttpPost]
        public IActionResult AddLocation(Location location)
        {
            if(location == null)
            {
                return BadRequest("Location Cannot be null");
            }


             _repo.Add(location);

            return Ok();
        }

    }
}

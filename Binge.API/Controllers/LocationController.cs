using Bing.Models;
using Microsoft.AspNetCore.Mvc;
using Bing.Service;

namespace Binge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {

        private readonly IRepository _repo;
        private readonly ICSVStreamer _csvStreamer;

        public LocationController(IRepository repo, ICSVStreamer csvStreamer)
        {
            _repo = repo;
            _csvStreamer = csvStreamer;
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


        [HttpGet("file")]
        public IActionResult GetCsvFromFile()
        {
            var csvData = _csvStreamer.GetCsvFromFile();
            return Ok(csvData);
        }

        //[HttpGet("database")]
        //public IActionResult GetCsvFromDatabase()
        //{
        //    var csvData = _csvStreamer.GetCsvFromDatabase();
        //    return Ok(csvData);
        //}

    }
}

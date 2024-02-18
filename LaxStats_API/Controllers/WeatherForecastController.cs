using LaxStats_API.Models;
using LaxStats_API.Services.LeagueServ;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.ComponentModel;

namespace LaxStats_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly LeagueService leagueService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //[HttpGet("GetLeague")]
        //public ActionResult<League> GetLeague()
        //{
        //    var model = leagueService.GetLeagues();
        //    Console.Write(model);
        //    return Ok(model);
        //}

        //[HttpGet("GetLeagueV2")]
        //public async Task<ActionResult<League>> GetLeagueV2()
        //{
        //    var model = leagueService.GetLeaguesList();
        //    Console.Write(model);
        //    return Ok(model);
        //}

        //[HttpGet("GetLeague")]
        //public async Task<ActionResult<LeagueService>> GetLeaguev2()
        //{
        //    List<LeagueService> leagues = new List<LeagueService>()
        //    {
        //        new LeagueService {Name = "OTO", Year = 2012},
        //        new LeagueService {Name = "Kie³", Year = 2023},
        //        new LeagueService {Name = "Œmród", Year = 2024}
        //    };
        //    return Ok(leagues);
        //}

        //[HttpGet("GetLeague")]
        //public async Task<ActionResult<LeagueService>> GetLeaguev3()
        //{
        //    List<LeagueService> leagues = new List<LeagueService>()
        //    {
        //        new LeagueService {Name = "OTO", Year = 2012},
        //        new LeagueService {Name = "Kie³", Year = 2023},
        //        new LeagueService {Name = "Œmród", Year = 2024}
        //    };
        //    return Ok(leagues);
        //}
    }
}
using LaxStats_API.Models;
using LaxStats_API.Services.LeagueServ;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats_API.Controllers
{
    [ApiController]
    [Route("League")]
    public class LeagueController : ControllerBase
    {
        private readonly ILogger<LeagueController> logger;
        private readonly ILeagueService leagueService;
        public LeagueController(ILogger<LeagueController> _logger, ILeagueService _leagueService) 
        {
            logger = _logger;
            leagueService = _leagueService;
        }

        [HttpGet("Test")]
        public IActionResult Get()
        {
            List<string> strings = new List<string>()
            {
                "Kieł","Moko","Poko"
            };
            return Ok(strings);
        }

        [HttpGet("GetLeagues")]
        public async Task<ActionResult<League>> GetLol()
        {
            var model = leagueService.GetLeagues();
            return Ok(model);
        }

        [HttpPost("AddLeague")]
        public IActionResult AddLeague(League league)
        {
            leagueService.AddLeague(league);
            return Ok();
        }
    }
}

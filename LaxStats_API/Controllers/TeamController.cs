using LaxStats.Models;
using LaxStats_API.Services.LeagueServ;
using LaxStats_API.Services.TeamServ;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats_API.Controllers
{
    [ApiController]
    [Route("Team")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService teamService;
        private readonly ILogger<TeamController> logger;

        public TeamController(ITeamService _teamService, ILogger<TeamController> _logger)
        {
            teamService =_teamService;
            logger = _logger;
        }
        [HttpGet("ShowAllTeams")]
        public IActionResult ShowTeams() 
        {
            var model = teamService.GetTeams();
            return Ok(model);
        }

        [HttpGet("GetTeamsInLeague")]
        public IActionResult ShowTeamsInLeague(int leagueId)
        {
            var model = teamService.GetTeamsInLeague(leagueId);
            return Ok(model);
        }

    }
}

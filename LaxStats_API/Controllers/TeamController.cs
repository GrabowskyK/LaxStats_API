using LaxStats.Models;
using LaxStats_API.DTO;
using LaxStats_API.Services.LeagueServ;
using LaxStats_API.Services.TeamServ;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats_API.Controllers
{
    [ApiController]
    [Route("Team")]
    public class TeamController : ControllerBase
    {
        private readonly ILogger<TeamController> logger;
        private readonly ITeamService teamService;
        private readonly ILeagueService leagueService;


        public TeamController(ILogger<TeamController> _logger, ITeamService _teamService,  ILeagueService _leagueService)
        {
            logger = _logger;
            teamService =_teamService;
            leagueService = _leagueService;
        }

        [HttpGet("GetTeamsInLeague")]
        public IActionResult ShowTeamsInLeague(int leagueId)
        {
            var model = teamService.GetTeamsInLeague(leagueId);
            return Ok(model);
        }

        [HttpPost("AddTeam")]
        public IActionResult AddTeamToLeague([FromBody] TeamDTO team)
        {
            var league = leagueService.GetLeagueById(team.LeagueId);
            Team newTeam = new Team()
            {
                Name = team.Name,
                ShortName = team.ShortName,
                LeagueId = team.LeagueId,
                League = league
            };
            teamService.AddTeam(newTeam);
            return Ok();
        }

        [HttpDelete("DeleteTeam")]
        public IActionResult DeleteTeamFromLeague(int teamId)
        {
            teamService.DeleteTeam(teamId);
            return Ok();
        }
    }
}

using LaxStats.Models;
using LaxStats_API.Database;
using LaxStats_API.DTO;
using LaxStats_API.Services.LeagueServ;
using LaxStats_API.Services.PlayerServ;
using LaxStats_API.Services.TeamServ;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats_API.Controllers
{
    public class PlayerController : ControllerBase
    {
        private readonly DatabaseContext databaseContext;
        private readonly ILogger<PlayerController> logger;
        private readonly IPlayerService playerService;
        private readonly ITeamService teamService;

        public PlayerController(ILogger<PlayerController> _logger, IPlayerService _playerService, ITeamService _teamService)
        {
            logger = _logger;
            playerService = _playerService;
            teamService = _teamService;
        }

        [HttpGet("PlayersInTeam")]
        public IActionResult AllPlayersInTeam(int teamId)
        {
            var model = playerService.GetPlayersInTeam(teamId);
            return Ok(model);
        }

        [HttpPost("AddPlayerToTeam")]
        public IActionResult AddPlayerToTeam([FromBody] PlayerDTO player)
        {
            //To find team
            var team = teamService.GetTeamById(player.TeamId);

            Player newPlayer = new Player()
            {
                Name = player.Name,
                Surname = player.Surname,
                Born = player.Born,
                ShirtNumber = player.ShirtNumber,
                TeamId = player.TeamId,
                Team = team
            };

            playerService.AddPlayer(newPlayer);
            return Ok();
        }

        [HttpDelete("DeletePlayerFromTeam")]
        public IActionResult DeletePlayerFromTeam(int playerId)
        {
            playerService.DeletePlayer(playerId);
            return Ok();
        }

    }
}

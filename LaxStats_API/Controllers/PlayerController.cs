using LaxStats.Models;
using LaxStats_API.Database;
using LaxStats_API.DTO;
using LaxStats_API.Services.LeagueServ;
using LaxStats_API.Services.PlayerServ;
using LaxStats_API.Services.TeamServ;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats_API.Controllers
{
    [ApiController]
    [Route("Player")]
    public class PlayerController : ControllerBase
    {
        private readonly ILogger<PlayerController> logger;
        private readonly IPlayerService playerService;

        public PlayerController(ILogger<PlayerController> _logger, IPlayerService _playerService)
        {
            logger = _logger;
            playerService = _playerService;
        }

        [HttpGet("PlayersInTeam")]
        public IActionResult AllPlayersInTeam(int teamId)
        {
            var model = playerService.GetPlayersInTeam(teamId);
            return Ok(model);
        }

        [HttpGet("XD")]
        public IActionResult XD(int teamId)
        {
            var model = playerService.xd(teamId);
            return Ok(model);
        }

        [HttpPost("AddPlayerToTeam")]
        public IActionResult AddPlayerToTeam([FromBody] PlayerDTO player)
        {
            Player newPlayer = new Player()
            {
                Name = player.Name,
                Surname = player.Surname,
                Born = player.Born,
                ShirtNumber = player.ShirtNumber,
                TeamId = player.TeamId,
            };

            playerService.AddPlayer(newPlayer);
            return Ok();
        }

        //There could be problem if player do something in any game. So this option should make a player "retirment"
        [HttpDelete("DeletePlayerFromTeam")]
        public IActionResult DeletePlayerFromTeam(int playerId)
        {
            playerService.DeletePlayer(playerId);
            return Ok();
        }


    }
}

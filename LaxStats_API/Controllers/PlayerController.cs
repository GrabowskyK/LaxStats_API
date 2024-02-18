using LaxStats_API.Database;
using LaxStats_API.Services.LeagueServ;
using LaxStats_API.Services.PlayerServ;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats_API.Controllers
{
    public class PlayerController : ControllerBase
    {
        private readonly DatabaseContext databaseContext;
        private readonly ILogger<PlayerController> logger;
        private readonly IPlayerService playerService;

        public PlayerController(ILogger<PlayerController> _logger, IPlayerService _playerService)
        {
            logger = _logger;
            playerService = _playerService;
        }

        [HttpGet("PlayersInTeam")]
        public IActionResult AllPlayersInTeam()
        {

            return Ok();
        }
    }
}

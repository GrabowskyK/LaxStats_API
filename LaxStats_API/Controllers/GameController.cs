using LaxStats_API.Services.GameServ;
using LaxStats_API.Services.LeagueServ;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats_API.Controllers
{
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> logger;
        private readonly IGameService gameService;
        public GameController(ILogger<GameController> _logger, IGameService _gameService)
        {
            logger = _logger;
            gameService = _gameService;
        }

    }
}

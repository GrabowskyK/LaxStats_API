using LaxStats.Models;
using LaxStats_API.DTO;
using LaxStats_API.Models;
using LaxStats_API.Services.GameServ;
using LaxStats_API.Services.LeagueServ;
using LaxStats_API.Services.TeamServ;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats_API.Controllers
{
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> logger;
        private readonly IGameService gameService;
        private readonly ITeamService teamService;
        public GameController(ILogger<GameController> _logger, IGameService _gameService, ITeamService _teamService)
        {
            logger = _logger;
            gameService = _gameService;
            teamService = _teamService;
        }

        [HttpPost("AddGame")]
        public IActionResult AddGame([FromBody] GameDTO game)
        {
            Game newGame = new Game()
            {
                HomeTeamId = game.HomeTeamId,
                AwayTeamId = game.AwayTeamId,
                DateTime = game.DateTime,
                Place = game.Place,
                LeagueId = game.LeagueId
            };
            gameService.AddGame(newGame);

            //When game is creating also the stats
            var team1 = teamService.GetTeamById(newGame.HomeTeamId);
            var team2 = teamService.GetTeamById(newGame.AwayTeamId);
            gameService.AddStatsToGame(newGame.Id, team1); //team1
            gameService.AddStatsToGame(newGame.Id, team2); //team2
            return Ok();
        }

        [HttpGet("AllGames")]
        public IActionResult ShowAllGames()
        {
            var model = gameService.GetGames();
            return Ok(model);
        }

        [HttpGet("GamesInLeague")]
        public async Task<ActionResult<IEnumerable<Game>>> GamesInLeague(int leagueId)
        {
            var games = gameService.GetGamesByLeagueId(leagueId);
            return Ok(games);
        }

        [HttpGet("GameStats")]
        public IActionResult GameStats(int gameId)
        {
            var gameStats = gameService.GetGameStats(gameId);
            return Ok(gameStats);
        }
    }
}

using LaxStats.Models;
using LaxStats_API.ViewModel;

namespace LaxStats_API.Services.GameServ
{
    public interface IGameService
    {
        public void AddGame(Game game);
        public IEnumerable<Game> GetGames();
        public IEnumerable<Game> GetGamesByLeagueId(int leagueId);
        public void AddStatsToGame(int gameId, Team teamName);
        public IEnumerable<Game> GetGameStats(int gameId);
    }
}
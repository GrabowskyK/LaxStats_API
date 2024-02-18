using LaxStats.Models;

namespace LaxStats_API.Services.PlayerServ
{
    public interface IPlayerService
    {
        public IEnumerable<Player> GetPlayersInTeam(int teamId);
    }
}
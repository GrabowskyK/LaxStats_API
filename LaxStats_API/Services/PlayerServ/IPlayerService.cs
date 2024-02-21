using LaxStats.Models;

namespace LaxStats_API.Services.PlayerServ
{
    public interface IPlayerService
    {
        public IEnumerable<Player> GetPlayersInTeam(int teamId);
        public List<Player> xd(int teamId);
        public void AddPlayer(Player player);
        public void DeletePlayer(int playerId);
    }
}
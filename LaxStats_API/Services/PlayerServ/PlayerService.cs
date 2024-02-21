using LaxStats.Models;
using LaxStats_API.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LaxStats_API.Services.PlayerServ
{
    public class PlayerService : IPlayerService
    {
        private readonly DatabaseContext databaseContext;

        public PlayerService(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        public IEnumerable<Player> GetPlayersInTeam(int teamId) => databaseContext.Players
            .Where(p => p.TeamId == teamId);

        public List<Player> xd(int teamId) => databaseContext.Players
            .Select(p => new Player { Name = p.Name, ShirtNumber = p.ShirtNumber})
            .ToList();
            
        
        public void AddPlayer(Player player)
        {
            databaseContext.Players.Add(player);
            databaseContext.SaveChanges();
        }
        public void DeletePlayer(int playerId)
        {
            var deletePlayer = databaseContext.Players
                .Where(p => p.Id == playerId)
                .FirstOrDefault();

            databaseContext.Players.Remove(deletePlayer);
            databaseContext.SaveChanges();
        }
    }
}

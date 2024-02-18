using LaxStats.Models;
using LaxStats_API.Database;
using Microsoft.EntityFrameworkCore;

namespace LaxStats_API.Services.TeamServ
{
    public class TeamService : ITeamService
    {
        private readonly DatabaseContext databaseContext;

        public TeamService(DatabaseContext _databaseContext) 
        { 
            databaseContext = _databaseContext;
        }

        public IEnumerable<Team> GetTeams() => databaseContext.Teams
            .Include(t => t.League)
            .Select(t => new Team
            {
                Id = t.Id,
                Name = t.Name,
                ShortName = t.ShortName,
                win = t.win,
                lose = t.lose,
                draw = t.draw,
                points = t.points,
                LeagueId = t.LeagueId,
                League = t.League
            });
        public IEnumerable<Team> GetTeamsInLeague(int leagueId) => databaseContext.Teams
            .Where(t => t.LeagueId == leagueId);
    }
}

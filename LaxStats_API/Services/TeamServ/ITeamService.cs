using LaxStats.Models;

namespace LaxStats_API.Services.TeamServ
{
    public interface ITeamService
    {
        public IEnumerable<Team> GetTeams();
        public IEnumerable<Team> GetTeamsInLeague(int leagueId);
        public Team GetTeamById(int teamId);
    }
}
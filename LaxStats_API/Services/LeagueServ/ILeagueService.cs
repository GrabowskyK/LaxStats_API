using LaxStats_API.Models;

namespace LaxStats_API.Services.LeagueServ
{
    public interface ILeagueService
    {
        public IEnumerable<League> GetLeagues();
        public List<League> GetLeaguesList();
        public void AddLeague(League league);
    }
}

using LaxStats_API.Database;
using LaxStats_API.Models;
using LaxStats_API.Services.LeagueServ;

namespace LaxStats_API.Services.LeagueServ
{
    public class LeagueService : ILeagueService
    {
        private readonly DatabaseContext databaseContext;
        public LeagueService(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        public IEnumerable<League> GetLeagues() => databaseContext.Leagues;
        public List<League> GetLeaguesList() => databaseContext.Leagues.ToList();
        public void AddLeague(League league)
        {
            databaseContext.Leagues.Add(league);
            databaseContext.SaveChanges();
        }

        public League GetLeagueById(int leagueId) => databaseContext.Leagues.Where(l => l.Id == leagueId).FirstOrDefault();
    }
}

using LaxStats.Models;
using LaxStats_API.Database;
using Microsoft.EntityFrameworkCore;

namespace LaxStats_API.Services.EventGoalServ
{
    public class EventGoalService : IEventGoalService
    {
        private readonly DatabaseContext databaseContext;
        public EventGoalService(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        public void ScoredGoal(EventGoal eventGoal)
        {
            var player = databaseContext.Players
                .Find(eventGoal.PlayerId);
            player.Goal += 1;
            databaseContext.EventGoals.Add(eventGoal);
            databaseContext.SaveChanges();
        }

        public IEnumerable<EventGoal> GetEventGoals() => databaseContext.EventGoals
            .Include(e => e.Player);
    }
}

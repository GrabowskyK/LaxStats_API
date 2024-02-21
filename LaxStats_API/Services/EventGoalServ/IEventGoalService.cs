using LaxStats.Models;

namespace LaxStats_API.Services.EventGoalServ
{
    public interface IEventGoalService
    {
        public void ScoredGoal(EventGoal eventGoal);
        public IEnumerable<EventGoal> GetEventGoals();
    }
}
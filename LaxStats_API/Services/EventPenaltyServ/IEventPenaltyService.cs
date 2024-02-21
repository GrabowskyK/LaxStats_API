using LaxStats.Models;

namespace LaxStats_API.Services.EventPenaltyServ
{
    public interface IEventPenaltyService
    {
        public void AddPenalty(EventPenalty eventPenalty);
    }
}
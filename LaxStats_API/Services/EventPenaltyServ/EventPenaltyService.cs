using LaxStats.Models;
using LaxStats_API.Database;
using Microsoft.EntityFrameworkCore;

namespace LaxStats_API.Services.EventPenaltyServ
{
    public class EventPenaltyService : IEventPenaltyService
    {
        private readonly DatabaseContext databaseContext;
        public EventPenaltyService(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        public void AddPenalty(EventPenalty eventPenalty)
        {
            databaseContext.EventPenalties.Add(eventPenalty);
            var player = databaseContext.Players
                .Find(eventPenalty.PlayerId);
                
            player.Penalties += 1;
            player.MinutesPenalties += eventPenalty.TimePenalty;
           // var xd = player.Penalty;
            databaseContext.SaveChanges();
        }
    }
}

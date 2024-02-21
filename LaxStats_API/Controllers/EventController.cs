using LaxStats.Models;
using LaxStats_API.DTO;
using LaxStats_API.Services.EventGoalServ;
using LaxStats_API.Services.EventPenaltyServ;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats_API.Controllers
{
    public class EventController : ControllerBase
    {
        private readonly ILogger<EventController> logger;
        private readonly IEventGoalService eventGoalService;
        private readonly IEventPenaltyService eventPenaltyService;

        public EventController(ILogger<EventController> _logger, IEventGoalService _eventGoalService, IEventPenaltyService _eventPenaltyService)
        {
            logger = _logger;
            eventGoalService = _eventGoalService;
            eventPenaltyService = _eventPenaltyService;
        }
        [HttpPost("AddGoalEvent")]
        public IActionResult ScoredEvent([FromBody] EventGoalDTO eventGoal)
        {
            EventGoal newEvent = new EventGoal(TimeSpan.Parse(eventGoal.Time.ToString()), eventGoal.PlayerId, eventGoal.GameId);
            if (eventGoal.AssistId != 0 && eventGoal.AssistId != null)
            {
                newEvent.AssistId = eventGoal.AssistId;
            }
            eventGoalService.ScoredGoal(newEvent);
            return Ok();
        }

        [HttpPost("AddPenaltyEvent")]
        public IActionResult PenaltyEvent([FromBody] EventPenaltyDTO eventPenalty)
        {
            EventPenalty newEvent = new EventPenalty(TimeSpan.Parse(eventPenalty.Time.ToString()), eventPenalty.PlayerId, (PenaltyType)eventPenalty.PenaltyType,eventPenalty.TimePenalty, eventPenalty.GameId);
            eventPenaltyService.AddPenalty(newEvent);
            return Ok();
        }

        [HttpGet("AllGoals")]
        public IActionResult Scored()
        {
            var goals = eventGoalService.GetEventGoals();
            return Ok(goals);
        }
    }
}

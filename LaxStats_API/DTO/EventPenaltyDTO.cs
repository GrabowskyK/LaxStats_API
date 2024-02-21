using LaxStats.Models;

namespace LaxStats_API.DTO
{
    public class EventPenaltyDTO
    {
        public string Time { get; set; }
        public int PlayerId { get; set; }
        public PenaltyType PenaltyType { get; set; }
        public int TimePenalty { get; set; }
        public int GameId {  get; set; }
    }
}
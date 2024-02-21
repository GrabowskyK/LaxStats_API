namespace LaxStats_API.DTO
{
    public class EventGoalDTO
    {
        public string Time { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int? AssistId { get; set; }
    }
}

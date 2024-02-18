namespace LaxStats.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Born { get; set; }
        public int ShirtNumber { get; set; }
        public int GamePlayed { get; set; }
        public int Goal {  get; set; }
        public int Assist { get; set; }
        public int Penalties { get; set; }
        public int MinutesPenalties { get; set; }
        
        public int TeamId { get; set; }
        public Team Team { get; set; } 

        ICollection<EventGoal> Goals { get; set; }
        ICollection<EventPenalty> Penalty { get; set; }

    }
}

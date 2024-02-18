namespace LaxStats.Models
{
    public class EventPenalty
    {
        public int Id { get; set; }
        public TimeSpan TimeEvent { get; set; } //when during the game
        public int PlayerId { get; set; }   
        public Player Player { get; set; } // who
        public PenaltyType PenaltyType { get; set; } //what type
        public int TimePenalty { get; set; } // 1minute, 2minute etc.
        public int GameId { get; set; }
        public Game Game { get; set; }

        public EventPenalty() { }
        public EventPenalty(TimeSpan timeEvent, Player player, PenaltyType penaltyType, int timePenalty, int gameId)
        {
            TimeEvent = timeEvent;
            Player = player;
            PenaltyType = penaltyType;
            TimePenalty = timePenalty;
            GameId = gameId;
        }
    }

    public enum PenaltyType 
    { 
        Push,
        Crosscheck,
        Slashing,
        Tripping,
        Holding,
        IllegalBodyCheck,
        CreaseViolation,
        IllegalSubstitution,
        DelayingTheGame
    }
}

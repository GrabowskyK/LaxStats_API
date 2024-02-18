namespace LaxStats.Models.MatchStats
{
    public class Timeouts
    {
        // When, which team took timeout. 
        public int Id { get; set; }
        public TimeSpan TookTimeout { get; set; }
        public string TeamName{ get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        
        public Timeouts() { }

        public Timeouts(TimeSpan time,  string team, int gameId)
        {
            TookTimeout = time;
            TeamName = team;
            GameId = gameId;
        }
    }
}

namespace LaxStats.Models.MatchStats
{
    public class GoalieSavesAndGoals
    {
        public int Id { get; set; }
        public int GameId { get;set; }
        public Game Game { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int Q1 { get; set; } = 0;
        public int Q2 { get; set; } = 0;
        public int Q3 { get; set; } = 0;
        public int Q4 { get; set; } = 0;
        public int OverTime { get; set; } = 0;

        public GoalieSavesAndGoals() { }
        public GoalieSavesAndGoals(int gameId, Player player)
        {
            GameId = gameId;
            Player = player;
        }
    }
}

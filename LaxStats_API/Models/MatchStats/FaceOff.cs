namespace LaxStats.Models.MatchStats
{
    public class FaceOff //This is the situation after goal, when players fight for ball in middle of field. Stats show which team won.
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public string TeamName { get;set; }
        public int Q1 {  get; set; } = 0;
        public int Q2 {  get; set; } = 0;
        public int Q3 {  get; set; } = 0;
        public int Q4 {  get; set; } = 0;
        public int OverTime { get; set; } = 0;

        public FaceOff() { }
        public FaceOff(int gameId, string teamName)
        {
            GameId = gameId;
            TeamName = teamName;
        }
    }
}

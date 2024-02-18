using LaxStats.Models.MatchStats;
using LaxStats_API.Models;

namespace LaxStats.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public DateTime DateTime { get; set; }
        public int ScoreHomeTeam { get; set; } = 0;
        public int ScoreAwayTeam { get; set; } = 0;
        public string Place { get; set; }
        public bool IsEnded { get; set; } = false;
        public int LeagueId { get; set; }
        public League League { get; set; }

        public ICollection<EventGoal> Goals { get; set; }
        public ICollection<EventPenalty> Penalty { get; set; }
        //Stats
        public ICollection<Timeouts> Timeouts { get; set; }
        public ICollection<FaceOff> FaceOffs { get; set; }
        public ICollection<Shots> Shots { get; set; }
        public ICollection<ShotsWide> ShotsWides { get; set; }
        public ICollection<Groundballs> Groundballs { get; set; }
       // public ICollection<GoalieSavesAndGoals> GoalieSaves { get; set; }
        public Game() { }

        public Game(Team homeTeam, Team awayTeam, League league)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            DateTime = DateTime.Now;
            Place = "Poland";
            League = league;
        }
    }
}

using LaxStats_API.Models;

namespace LaxStats.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int win { get; set; }
        public int lose { get; set; }
        public int draw { get; set; }
        public int points { get; set; } = 0;
        public int LeagueId { get; set; }
        public League League { get; set; }
        public ICollection<Player> Players { get; }

        public ICollection<Game> HomeGames { get; set; }
        public ICollection<Game> AwayGames { get; set; }

    }
}

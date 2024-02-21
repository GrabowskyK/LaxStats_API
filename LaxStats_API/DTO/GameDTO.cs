using LaxStats.Models;
using LaxStats_API.Models;

namespace LaxStats_API.DTO
{
    public class GameDTO
    {
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public DateTime DateTime { get; set; }
        public string Place { get; set; }
        public int LeagueId { get; set; }   
    }
}
using LaxStats.Models;

namespace LaxStats_API.Models
{
    public class PlayerGoalie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Born { get; set; }
        public int ShirtNumber { get; set; }
        public int GamePlayed { get; set; } = 0;
        public int Saves { get; set; } = 0;
        public int Goals { get; set; } = 0;
        public int TeamId { get; set; }
        public Team Team { get; set; }


    }
}

using LaxStats.Models;

namespace LaxStats_API.DTO
{
    public class PlayerDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Born { get; set; }
        public int ShirtNumber { get; set; }
        public int TeamId { get; set; }

    }
}

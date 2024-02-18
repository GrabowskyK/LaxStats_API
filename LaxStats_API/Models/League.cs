using LaxStats.Models;

namespace LaxStats_API.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public ICollection<Team> Teams { get; set; }
        public League() { }
        public League(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
}

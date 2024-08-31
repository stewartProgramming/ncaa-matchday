namespace ncaa_matchday.Models
{
    public class HomeMatches
    {
        public required string Sport { get; set; }
        public List<Divisions>? DivisionMatches { get; set; }

        public class Divisions
        {
            public required string Division { get; set; }
            public List<Game2?>? Matches { get; set; }
        }
    }
}

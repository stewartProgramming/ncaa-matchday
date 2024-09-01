namespace ncaa_matchday.Models.LeagueModels
{
    public class Matches
    {
        public required string Sport { get; set; }
        public required string Division { get; set; }
        public IEnumerable<Game2?>? Games { get; set; }
    }
}

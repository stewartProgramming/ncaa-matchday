using System.Text.Json.Serialization;

namespace ncaa_matchday.Models
{
    public class Game
    {
        [JsonPropertyName("game")]
        public Game2? game { get; set; }
    }
}

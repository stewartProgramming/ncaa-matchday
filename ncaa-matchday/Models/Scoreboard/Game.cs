using System.Text.Json.Serialization;

namespace ncaa_matchday.Models
{
    public class Game
    {
        [JsonPropertyName("game")]
        public required Game2 game { get; set; }
    }
}

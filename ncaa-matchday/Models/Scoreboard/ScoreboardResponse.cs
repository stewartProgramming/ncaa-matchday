using System.Text.Json.Serialization;

namespace ncaa_matchday.Models
{
    public class ScoreboardResponse
    {
        [JsonPropertyName("inputMD5Sum")]
        public string? InputMD5Sum { get; set; }

        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("games")]
        public List<Game>? Games { get; set; }
    }
}

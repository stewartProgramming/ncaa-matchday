using System.Text.Json.Serialization;

namespace ncaa_matchday.Models
{
    public class Conference
    {
        [JsonPropertyName("conferenceName")]
        public string? ConferenceName { get; set; }

        [JsonPropertyName("conferenceSeo")]
        public string? ConferenceSeo { get; set; }
    }
}

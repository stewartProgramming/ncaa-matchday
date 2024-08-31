using System.Text.Json.Serialization;

namespace ncaa_matchday.Models
{
    public class Names
    {
        [JsonPropertyName("char6")]
        public string? Char6 { get; set; }

        [JsonPropertyName("short")]
        public string? Short { get; set; }

        [JsonPropertyName("seo")]
        public string? Seo { get; set; }

        [JsonPropertyName("full")]
        public string? Full { get; set; }
    }
}

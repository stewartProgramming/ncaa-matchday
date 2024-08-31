using System.Text.Json.Serialization;

namespace ncaa_matchday.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Away
    {
        [JsonPropertyName("score")]
        public string? Score { get; set; }

        [JsonPropertyName("names")]
        public Names? Names { get; set; }

        [JsonPropertyName("winner")]
        public bool? Winner { get; set; }

        [JsonPropertyName("seed")]
        public string? Seed { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("rank")]
        public string? Rank { get; set; }

        [JsonPropertyName("conferences")]
        public List<Conference>? Conferences { get; set; }
    }
}

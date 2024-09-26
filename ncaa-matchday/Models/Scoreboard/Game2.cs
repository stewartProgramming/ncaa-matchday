using ncaa_matchday.Models.Scoreboard;
using System.Text.Json.Serialization;

namespace ncaa_matchday.Models
{
    public class Game2
    {
        [JsonPropertyName("gameID")]
        public string? GameID { get; set; }

        [JsonPropertyName("away")]
        public required ScoreboardTeam Away { get; set; }

        [JsonPropertyName("finalMessage")]
        public string? FinalMessage { get; set; }

        [JsonPropertyName("bracketRound")]
        public string? BracketRound { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("contestName")]
        public string? ContestName { get; set; }

        [JsonPropertyName("url")]
        public required string Url { get; set; }

        [JsonPropertyName("network")]
        public string? Network { get; set; }

        [JsonPropertyName("home")]
        public required ScoreboardTeam Home { get; set; }

        [JsonPropertyName("liveVideoEnabled")]
        public bool? LiveVideoEnabled { get; set; }

        [JsonPropertyName("startTime")]
        public required string StartTime { get; set; }

        [JsonPropertyName("startTimeEpoch")]
        public string? StartTimeEpoch { get; set; }

        [JsonPropertyName("bracketId")]
        public string? BracketId { get; set; }

        [JsonPropertyName("gameState")]
        public string? GameState { get; set; }

        [JsonPropertyName("startDate")]
        public required string StartDate { get; set; }

        [JsonPropertyName("currentPeriod")]
        public string? CurrentPeriod { get; set; }

        [JsonPropertyName("videoState")]
        public string? VideoState { get; set; }

        [JsonPropertyName("bracketRegion")]
        public string? BracketRegion { get; set; }

        [JsonPropertyName("contestClock")]
        public string? ContestClock { get; set; }
    }
}

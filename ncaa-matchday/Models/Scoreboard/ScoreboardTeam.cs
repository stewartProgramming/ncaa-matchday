﻿using System.Text.Json.Serialization;

namespace ncaa_matchday.Models.Scoreboard
{
    public class ScoreboardTeam
    {
        [JsonPropertyName("score")]
        public required string Score { get; set; }

        [JsonPropertyName("names")]
        public required Names Names { get; set; }

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

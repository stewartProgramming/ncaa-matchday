using System.Text.Json.Serialization;

namespace ncaa_matchday.Models.MatchModels
{
    public class ScoringMeta
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("teams")]
        public List<ScoringTeam> Teams { get; set; }
    }

    public class ScoringPeriod
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("summary")]
        public List<Summary> Summary { get; set; }
    }

    public class NCAA_Scoring
    {
        [JsonPropertyName("meta")]
        public ScoringMeta Meta { get; set; }

        [JsonPropertyName("periods")]
        public List<ScoringPeriod> Periods { get; set; }
    }

    public class Summary
    {
        [JsonPropertyName("teamId")]
        public string TeamId { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("scoreType")]
        public string ScoreType { get; set; }

        [JsonPropertyName("scoreText")]
        public string ScoreText { get; set; }

        [JsonPropertyName("visitingScore")]
        public string VisitingScore { get; set; }

        [JsonPropertyName("homeScore")]
        public string HomeScore { get; set; }
    }

    public class ScoringTeam
    {
        [JsonPropertyName("homeTeam")]
        public string HomeTeam { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("shortname")]
        public string Shortname { get; set; }

        [JsonPropertyName("seoName")]
        public string SeoName { get; set; }

        [JsonPropertyName("sixCharAbbr")]
        public string SixCharAbbr { get; set; }
    }
}

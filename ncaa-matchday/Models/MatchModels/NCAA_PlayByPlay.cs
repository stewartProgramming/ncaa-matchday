using ncaa_matchday.Models.MatchModels.Matchday.Models.NCAA;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ncaa_matchday.Models.MatchModels
{
    public class PlayByPlayMeta
    {
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("division")]
        [JsonPropertyName("division")]
        public string Division { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("period")]
        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonProperty("minutes")]
        [JsonPropertyName("minutes")]
        public string Minutes { get; set; }

        [JsonProperty("seconds")]
        [JsonPropertyName("seconds")]
        public string Seconds { get; set; }

        [JsonProperty("teams")]
        [JsonPropertyName("teams")]
        public List<Team> Teams { get; set; }
    }

    public class Period
    {
        [JsonProperty("periodNumber")]
        [JsonPropertyName("periodNumber")]
        public string PeriodNumber { get; set; }

        [JsonProperty("periodDisplay")]
        [JsonPropertyName("periodDisplay")]
        public string PeriodDisplay { get; set; }

        [JsonProperty("playStats")]
        [JsonPropertyName("playStats")]
        public List<PlayStat> PlayStats { get; set; }
    }

    public class PlayStat
    {
        [JsonProperty("score")]
        [JsonPropertyName("score")]
        public string Score { get; set; }

        [JsonProperty("time")]
        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonProperty("visitorText")]
        [JsonPropertyName("visitorText")]
        public string VisitorText { get; set; }

        [JsonProperty("homeText")]
        [JsonPropertyName("homeText")]
        public string HomeText { get; set; }
    }

    public class NCAA_PlayByPlay
    {
        [JsonProperty("inputMD5Sum")]
        [JsonPropertyName("inputMD5Sum")]
        public string InputMD5Sum { get; set; }

        [JsonProperty("updatedTimestamp")]
        [JsonPropertyName("updatedTimestamp")]
        public string UpdatedTimestamp { get; set; }

        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public PlayByPlayMeta Meta { get; set; }

        [JsonProperty("periods")]
        [JsonPropertyName("periods")]
        public List<Period> Periods { get; set; }
    }
}

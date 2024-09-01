namespace ncaa_matchday.Models.MatchModels
{
    using System.Text.Json.Serialization;

    namespace Matchday.Models.NCAA
    {
        public class NCAA_GameInfo
        {
            [JsonPropertyName("inputMD5Sum")]
            public string inputMD5Sum { get; set; }

            [JsonPropertyName("updatedTimestamp")]
            public string updatedTimestamp { get; set; }

            [JsonPropertyName("meta")]
            public Meta meta { get; set; }

            [JsonPropertyName("teams")]
            public List<Team> teams { get; set; }
        }

        public class GoalieHeader
        {
            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("jerseyNum")]
            public string jerseyNum { get; set; }

            [JsonPropertyName("minutesAtGoalie")]
            public string minutesAtGoalie { get; set; }

            [JsonPropertyName("goalsAllowed")]
            public string goalsAllowed { get; set; }

            [JsonPropertyName("saves")]
            public string saves { get; set; }
        }

        public class GoalieStat
        {
            public GoalieStat()
            {

            }

            public GoalieStat(string firstName, string lastName, string jerseyNum,
                string started, string minutesAtGoalie, string goalsAllowed, string saves
                /*string yellowCards, string redCards*/)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.jerseyNum = jerseyNum;
                this.started = started;
                this.minutesAtGoalie = minutesAtGoalie;
                this.goalsAllowed = goalsAllowed;
                this.saves = saves;
                //this.yellowCards = yellowCards;
                //this.redCards = redCards;
            }

            [JsonPropertyName("firstName")]
            public string firstName { get; set; }

            [JsonPropertyName("lastName")]
            public string lastName { get; set; }

            [JsonPropertyName("jerseyNum")]
            public string jerseyNum { get; set; }

            [JsonPropertyName("started")]
            public string started { get; set; }

            [JsonPropertyName("minutesAtGoalie")]
            public string minutesAtGoalie { get; set; }

            [JsonPropertyName("goalsAllowed")]
            public string goalsAllowed { get; set; }

            [JsonPropertyName("saves")]
            public string saves { get; set; }

            //public string yellowCards { get; set; }
            //public string redCards { get; set; }
        }

        public class GoalieTotals
        {
            [JsonPropertyName("minutesAtGoalie")]
            public string minutesAtGoalie { get; set; }

            [JsonPropertyName("saves")]
            public string saves { get; set; }

            [JsonPropertyName("goalsAllowed")]
            public string goalsAllowed { get; set; }
        }

        public class Meta
        {
            [JsonPropertyName("title")]
            public string title { get; set; }

            [JsonPropertyName("description")]
            public string description { get; set; }

            [JsonPropertyName("sport")]
            public string sport { get; set; }

            [JsonPropertyName("division")]
            public string division { get; set; }

            [JsonPropertyName("gametype")]
            public string gametype { get; set; }

            [JsonPropertyName("status")]
            public string status { get; set; }

            [JsonPropertyName("period")]
            public string period { get; set; }

            [JsonPropertyName("minutes")]
            public string minutes { get; set; }

            [JsonPropertyName("seconds")]
            public string seconds { get; set; }

            [JsonPropertyName("teams")]
            public List<Team> teams { get; set; }
        }

        public class PlayerHeader
        {
            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("jerseyNum")]
            public string jerseyNum { get; set; }

            [JsonPropertyName("position")]
            public string position { get; set; }

            [JsonPropertyName("minutesPlayed")]
            public string minutesPlayed { get; set; }

            [JsonPropertyName("goals")]
            public string goals { get; set; }

            [JsonPropertyName("assists")]
            public string assists { get; set; }

            [JsonPropertyName("shots")]
            public string shots { get; set; }

            [JsonPropertyName("shotsOnGoal")]
            public string shotsOnGoal { get; set; }

            [JsonPropertyName("yellowCards")]
            public string yellowCards { get; set; }

            [JsonPropertyName("redCards")]
            public string redCards { get; set; }
        }

        public class PlayerStat
        {
            [JsonPropertyName("firstName")]
            public string firstName { get; set; }

            [JsonPropertyName("lastName")]
            public string lastName { get; set; }

            [JsonPropertyName("jerseyNum")]
            public string jerseyNum { get; set; }

            [JsonPropertyName("position")]
            public string position { get; set; }

            [JsonPropertyName("started")]
            public string started { get; set; }

            [JsonPropertyName("participated")]
            public string participated { get; set; }

            [JsonPropertyName("minutesPlayed")]
            public string minutesPlayed { get; set; }

            [JsonPropertyName("goals")]
            public string goals { get; set; }

            [JsonPropertyName("assists")]
            public string assists { get; set; }

            [JsonPropertyName("shots")]
            public string shots { get; set; }

            [JsonPropertyName("shotsOnGoal")]
            public string shotsOnGoal { get; set; }

            [JsonPropertyName("yellowCards")]
            public string yellowCards { get; set; }

            [JsonPropertyName("redCards")]
            public string redCards { get; set; }
        }

        public class PlayerTotals
        {
            [JsonPropertyName("goals")]
            public string goals { get; set; }

            [JsonPropertyName("assists")]
            public string assists { get; set; }

            [JsonPropertyName("shots")]
            public string shots { get; set; }

            [JsonPropertyName("shotsOnGoal")]
            public string shotsOnGoal { get; set; }

            [JsonPropertyName("yellowCards")]
            public string yellowCards { get; set; }

            [JsonPropertyName("redCards")]
            public string redCards { get; set; }
        }



        public class Team
        {
            public Team()
            {

            }

            public Team(Team team, Team metaTeam)
            {
                teamId = team.teamId;
                playerHeader = team.playerHeader;
                playerStats = team.playerStats;
                goalieHeader = team.goalieHeader;
                goalieStats = team.goalieStats;
                playerTotals = team.playerTotals;
                goalieTotals = team.goalieTotals;
                totalStats = team.totalStats;
                scores = team.scores;

                sixCharAbbr = metaTeam.sixCharAbbr;
                id = metaTeam.id;
                homeTeam = metaTeam.homeTeam;
                seoName = metaTeam.seoName;
                nickName = metaTeam.nickName;
                shortName = metaTeam.shortName;
                color = metaTeam.color;
            }

            [JsonPropertyName("homeTeam")]
            public string homeTeam { get; set; }

            [JsonPropertyName("id")]
            public string id { get; set; }

            [JsonPropertyName("seoName")]
            public string seoName { get; set; }

            [JsonPropertyName("sixCharAbbr")]
            public string sixCharAbbr { get; set; }

            [JsonPropertyName("shortName")]
            public string shortName { get; set; }

            [JsonPropertyName("nickName")]
            public string nickName { get; set; }

            [JsonPropertyName("color")]
            public string color { get; set; }

            [JsonPropertyName("teamId")]
            public int? teamId { get; set; }

            [JsonPropertyName("playerHeader")]
            public PlayerHeader playerHeader { get; set; }

            [JsonPropertyName("playerStats")]
            public List<PlayerStat> playerStats { get; set; }

            [JsonPropertyName("goalieHeader")]
            public GoalieHeader goalieHeader { get; set; }

            [JsonPropertyName("goalieStats")]
            public List<GoalieStat> goalieStats { get; set; }

            [JsonPropertyName("playerTotals")]
            public PlayerTotals playerTotals { get; set; }

            [JsonPropertyName("goalieTotals")]
            public GoalieTotals goalieTotals { get; set; }

            [JsonPropertyName("totalStats")]
            public TotalStats totalStats { get; set; }

            [JsonPropertyName("scores")]
            public List<object> scores { get; set; }
        }

        public class TotalStats
        {
            [JsonPropertyName("shots")]
            public string shots { get; set; }

            [JsonPropertyName("shotsOnGoal")]
            public string shotsOnGoal { get; set; }

            [JsonPropertyName("saves")]
            public string saves { get; set; }

            [JsonPropertyName("fouls")]
            public string fouls { get; set; }

            [JsonPropertyName("corners")]
            public string corners { get; set; }

            [JsonPropertyName("offsides")]
            public string offsides { get; set; }
        }
    }

}

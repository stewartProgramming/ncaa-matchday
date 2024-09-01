using ncaa_matchday.Models.MatchModels.Matchday.Models.NCAA;

namespace ncaa_matchday.Models.MatchModels
{
    public class NCAA_Details
    {
        public NCAA_Details() { }

        public NCAA_Details(NCAA_GameInfo? gameInfo, NCAA_PlayByPlay? playByPlay, NCAA_Scoring? scoring)
        {
            GameInfo = gameInfo;
            PlayByPlay = playByPlay;
            Scoring = scoring;
        }

        public NCAA_GameInfo? GameInfo { get; set; }
        public NCAA_PlayByPlay? PlayByPlay { get; set; }
        public NCAA_Scoring? Scoring { get; set; }
    }
}

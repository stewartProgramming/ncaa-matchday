using ncaa_matchday.Models.MatchModels.Matchday.Models.NCAA;

namespace ncaa_matchday.Models.MatchModels
{
    public class NCAA_Details
    {
        public NCAA_Details() { }

        public NCAA_Details(NCAA_GameInfo? gameInfo, NCAA_PlayByPlay? playByPlay)
        {
            GameInfo = gameInfo;
            PlayByPlay = playByPlay;
        }

        public NCAA_GameInfo? GameInfo { get; set; }
        public NCAA_PlayByPlay? PlayByPlay { get; set; }
    }
}

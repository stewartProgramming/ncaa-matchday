using Microsoft.AspNetCore.Mvc;
using ncaa_matchday.Models;
using ncaa_matchday.Models.MatchModels;
using ncaa_matchday.Models.MatchModels.Matchday.Models.NCAA;
using Newtonsoft.Json;

namespace ncaa_matchday.Controllers
{
    public class MatchController(IConfiguration config) : Controller
    {
        private readonly string? RapidApiLink = config["Links:Api"];
        private readonly string? Key = config["Headers:Api:Key"];
        private readonly string? Host = config["Headers:Api:Host"];

        public async Task<IActionResult> Details(string gameId)
        {
            string? gameInfoResponse = await NcaaDAL.CallRapidNCAA_API($"{RapidApiLink}/game/boxscore?id={gameId}", Key, Host);
            NCAA_GameInfo? gameInfoConverted = JsonConvert.DeserializeObject<NCAA_GameInfo?>(gameInfoResponse);

            string? playByPlayResponse = await NcaaDAL.CallRapidNCAA_API($"{RapidApiLink}/game/playbyplay?id={gameId}", Key, Host);
            NCAA_PlayByPlay? playByPlayConverted = JsonConvert.DeserializeObject<NCAA_PlayByPlay?>(playByPlayResponse);

            NCAA_Details matchDetails = new(gameInfoConverted, playByPlayConverted);

            return View(matchDetails);
        }
    }
}

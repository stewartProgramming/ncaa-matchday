using Microsoft.AspNetCore.Mvc;
using ncaa_matchday.Models;
using ncaa_matchday.Models.HomeModels;
using ncaa_matchday.Models.LeagueModels;
using Newtonsoft.Json;

namespace ncaa_matchday.Controllers
{
    public class LeagueController(IConfiguration config) : Controller
    {
        private readonly List<HomeList.League> Leagues = new HomeList().Leagues;

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Matches(string leagueLink, string date)
        {
            var dateParsed = DateTime.Now;
            if (!string.IsNullOrEmpty(date))
                dateParsed = DateTime.Parse(date);

            string uriString = string.Empty;
            string dateString = string.Empty;
            string? link = config["Links:Base"];
            string division = leagueLink.Split('/').Last();
            string sport = leagueLink.Split('/').First();
            if (sport.Contains('-'))
                sport = sport.Split('-').First();
            sport = char.ToUpper(sport[0]) + sport[1..];

            bool leagueIsFootball = leagueLink.Contains("football");

            if (leagueIsFootball == true)
            {
                var footballWeek = NcaaDAL.GetFootballWeek(dateParsed);

                dateString = dateParsed.Year.ToString();
                dateString = $"{dateParsed.Year}/{footballWeek}";
            }
            else
            {
                dateString = $"{dateParsed.Year}/{dateParsed.Month:D2}/{dateParsed.Day:D2}";
            }

            List<Matches> matchesToReturn = [];

            foreach (var league in Leagues.Where(x => x.Sport == sport))
            {
                var matches = await NcaaDAL.CallBaseNCAA_API($"{link}/scoreboard/{league.Link}/{dateString}/scoreboard.json");
                if (matches != null)
                {
                    var stringResponseConverted = JsonConvert.DeserializeObject<ScoreboardResponse>(matches);
                    if (stringResponseConverted != null && stringResponseConverted.Games != null)
                    {
                        var matchesModelToReturn = new Matches
                        {
                            Sport = league.Sport,
                            Sex = league.Sex,
                            LeagueLink = league.Link,
                            Division = league.Division.ToUpper(),
                            Games = stringResponseConverted.Games.Select(x => x.game).ToList()
                        };

                        if (leagueIsFootball == true)
                        {
                            matchesModelToReturn.Games = matchesModelToReturn.Games
                                .Where(x => x != null && x.StartDate != null && DateTime.Parse(x.StartDate).Date == DateTime.Today)
                                .ToList();
                        }

                        matchesToReturn.Add(matchesModelToReturn);
                    }
                }
            }

            return View(matchesToReturn);
        }
    }
}

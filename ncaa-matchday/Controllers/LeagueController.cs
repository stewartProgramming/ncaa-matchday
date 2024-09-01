using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using ncaa_matchday.Models;
using ncaa_matchday.Models.LeagueModels;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ncaa_matchday.Controllers
{
    public class LeagueController(IConfiguration config) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Matches(string leagueLink, DateTime? date)
        {
            date ??= DateTime.Now.AddDays(-1);

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
                var footballWeek = NcaaDAL.GetFootballWeek((DateTime)date);

                dateString = date.Value.Year.ToString();
                dateString = $"{date.Value.Year}/{footballWeek}";
            }
            else
            {
                dateString = $"{date.Value.Year}/{date.Value.Month:D2}/{date.Value.Day}";
            }

            var matches = await NcaaDAL.CallBaseNCAA_API($"{link}/scoreboard/{leagueLink}/{dateString}/scoreboard.json");
            if (matches != null)
            {
                var stringResponseConverted = JsonConvert.DeserializeObject<ScoreboardResponse>(matches);
                if (stringResponseConverted != null && stringResponseConverted.Games != null)
                {
                    var matchesModelToReturn = new Matches
                    {
                        Sport = sport,
                        Division = division.ToUpper(),
                        Games = stringResponseConverted.Games.Select(x => x.game).ToList()
                    };

                    if (leagueIsFootball == true)
                    {
                        matchesModelToReturn.Games = matchesModelToReturn.Games
                            .Where(x => x != null && x.StartDate != null && DateTime.Parse(x.StartDate).Date == DateTime.Today)
                            .ToList();
                    }

                    return View(matchesModelToReturn);
                }
                else
                {
                    return View(new Matches()
                    {
                        Sport = sport,
                        Division = division.ToUpper()
                    });
                }
            }
            else
            {
                return View(new Matches()
                {
                    Sport = sport,
                    Division = division.ToUpper()
                });
            }
        }
    }
}

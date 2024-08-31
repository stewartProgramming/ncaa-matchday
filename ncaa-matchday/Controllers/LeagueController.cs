using Microsoft.AspNetCore.Mvc;
using ncaa_matchday.Models;
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
            string? link = config["Links:Base"];
            bool leagueIsFootball = leagueLink.Contains("football");

            if (link == null)
            {
                return View(
                    new ErrorViewModel
                    {
                        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                    });
            }
            else
            {
                date ??= DateTime.Now;

                string uriString = string.Empty;
                string dateString = string.Empty;

                if (leagueIsFootball == true)
                {
                    var footballWeek = NcaaDAL.GetFootballWeek((DateTime)date);

                    dateString = date.Value.Year.ToString();
                    uriString = $"{link}scoreboard/{leagueLink}/{dateString}/scoreboard.json";
                }
                else
                {
                    dateString = $"{date.Value.Year}/{date.Value.Month:D2}/{date.Value.Day}";
                    uriString = $"{link}scoreboard/{leagueLink}/{dateString}/scoreboard.json";
                }

                HttpClient client = new();

                HttpRequestMessage request = new()
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{link}scoreboard/{leagueLink}/{dateString}/scoreboard.json")
                };

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string stringResponse = await response.Content.ReadAsStringAsync();
                    var stringResponseConverted = JsonConvert.DeserializeObject<ScoreboardResponse>(stringResponse);
                    if (stringResponseConverted != null && stringResponseConverted.Games != null)
                    {
                        var gamesToReturn = new List<Game2?>();
                        if (leagueIsFootball == true)
                        {
                            gamesToReturn = stringResponseConverted.Games
                                .Select(x => x.game)
                                .Where(x => x != null && x.StartDate != null && DateTime.Parse(x.StartDate).Date == DateTime.Today)
                                .ToList();
                        }
                        else
                        {
                            gamesToReturn = stringResponseConverted.Games
                                .Select(x => x.game)
                                .Where(x => x != null)
                                .ToList();
                        }

                        return View(gamesToReturn);
                    }
                    else
                    {
                        return View(
                        new ErrorViewModel
                        {
                            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                        });
                    }
                }
                else
                {
                    return View(
                    new ErrorViewModel
                    {
                        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                    });
                }
            }
        }
    }
}

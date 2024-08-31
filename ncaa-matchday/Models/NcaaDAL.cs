using Newtonsoft.Json;

namespace ncaa_matchday.Models
{
    public class NcaaDAL()
    {
        public static async Task<List<HomeMatches>> GetMatchesByDateAsync
            (List<string> sports, string link, DateTime? date)
        {
            date ??= DateTime.Now;
            string dateString = string.Empty;
            HttpClient client = new();
            List<HomeMatches> matchesOfTheDay = [];

            var sportsList = sports.Select(x => x.Split('/').First()).Distinct();
            foreach (string sport in sportsList)
            {
                var sportName = string.Empty;
                if (sport.Contains('-'))
                {
                    var sportNameSplit = sport.Split('-');

                    sportName = $"{char.ToUpper(sportNameSplit[0][0]) + sportNameSplit[0][1..]}-" +
                        $"{char.ToUpper(sportNameSplit[1][0]) + sportNameSplit[1][1..]}";
                }
                else
                {
                    sportName = char.ToUpper(sport[0]) + sport[1..];
                }

                var newHomeMatch = new HomeMatches
                {
                    Sport = sportName,
                    DivisionMatches = []
                };

                var sportDivisions = sports.Where(x => x.Contains(sport)).Select(x => x.Split('/')[1]).Distinct();
                foreach (var division in sportDivisions)
                {
                    
                    ///scoreboard/football/fbs/2024/01/scoreboard.json
                    string uriString = string.Empty;
                    if (sport.Contains("football"))
                    {
                        var footballWeek = GetFootballWeek((DateTime)date);

                        if (footballWeek == null)
                            continue;
                        else
                            uriString = $"{link}scoreboard/football/{division}/{date.Value.Year}/{footballWeek}/scoreboard.json";
                    }
                    else
                    {
                        dateString = $"/{date.Value.Year}/{date.Value.Month:D2}/{date.Value.Day}/";
                        uriString = $"{link}scoreboard/{sport}/{division}{dateString}scoreboard.json";
                    }

                    HttpRequestMessage request = new()
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri(uriString),
                    };

                    HttpResponseMessage response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        var stringResponse = await response.Content.ReadAsStringAsync();
                        var stringResponseConverted = JsonConvert
                            .DeserializeObject<ScoreboardResponse>(stringResponse);
                        if (stringResponseConverted != null && stringResponseConverted.Games != null)
                        {
                            var divisionMatchesToAdd = stringResponseConverted.Games
                                .Select(x => x.game)
                                .Where(x => x != null && x.StartDate != null && DateTime.Parse(x.StartDate).Date == DateTime.Today)
                                .ToList();

                            if (divisionMatchesToAdd.Count != 0)
                            {
                                var newDivision = new HomeMatches.Divisions()
                                {
                                    Division = division,
                                    Matches = divisionMatchesToAdd,
                                };

                                newHomeMatch.DivisionMatches.Add(newDivision);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                if (newHomeMatch.DivisionMatches.Select(x => x.Matches).Any())
                {
                    matchesOfTheDay.Add(newHomeMatch);
                }

            }

            return matchesOfTheDay;
        }

        public static string GetFootballWeek(DateTime date)
        {
            if (date > DateTime.Parse("2024-08-24") && date < DateTime.Parse("2024-09-03"))
                return "01";
            else if (date > DateTime.Parse("2024-09-04") && date < DateTime.Parse("2024-09-08"))
                return "02";
            else if (date > DateTime.Parse("2024-09-11") && date < DateTime.Parse("2024-09-17"))
                return "03";
            else if (date > DateTime.Parse("2024-09-19") && date < DateTime.Parse("2024-09-23"))
                return "04";
            else if (date > DateTime.Parse("2024-09-26") && date < DateTime.Parse("2024-09-29"))
                return "05";
            else if (date > DateTime.Parse("2024-10-03") && date < DateTime.Parse("2024-10-07"))
                return "06";
            else if (date > DateTime.Parse("2024-10-08") && date < DateTime.Parse("2024-10-13"))
                return "07";
            else if (date > DateTime.Parse("2024-10-15") && date < DateTime.Parse("2024-10-20"))
                return "08";
            else if (date > DateTime.Parse("2024-10-22") && date < DateTime.Parse("2024-10-28"))
                return "09";
            else if (date > DateTime.Parse("2024-10-29") && date < DateTime.Parse("2024-11-03"))
                return "10";
            else if (date > DateTime.Parse("2024-11-06") && date < DateTime.Parse("2024-11-10"))
                return "11";
            else if (date > DateTime.Parse("2024-11-12") && date < DateTime.Parse("2024-11-17"))
                return "12";
            else if (date > DateTime.Parse("2024-11-20") && date < DateTime.Parse("2024-11-24"))
                return "13";
            else if (date > DateTime.Parse("2024-11-26") && date < DateTime.Parse("2024-12-01"))
                return "14";
            else if (date > DateTime.Parse("2024-12-13"))
                return "P";
            else
                return null;
        }
    }
}

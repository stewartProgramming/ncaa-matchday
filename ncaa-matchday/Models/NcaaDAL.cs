namespace ncaa_matchday.Models
{
    public class NcaaDAL()
    {
        public static async Task<string> CallBaseNCAA_API(string link)
        {
            HttpClient client = new();

            HttpRequestMessage request = new()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(link)
            };

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return "null";
            }
        }

        public static async Task<string> CallRapidNCAA_API(string link, string key, string host)
        {
            HttpClient client = new();
            HttpRequestMessage request = new()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(link),
                Headers =
                {
                    { "x-rapidapi-key", key },
                    { "x-rapidapi-host", host }
                }
            };
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return "null";
            }
        }

        public static string? GetFootballWeek(DateTime date)
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

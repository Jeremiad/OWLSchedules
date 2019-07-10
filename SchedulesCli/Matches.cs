using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SchedulesCli
{
    public static class Matches
    {
        static readonly string url = "https://api.overwatchleague.com/schedule";
        public static async Task<List<DateTimeOffset>> Dates()
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);

            var model = JsonConvert.DeserializeObject<Models.ScheduleModel>(json);

            List<DateTimeOffset> dates = new List<DateTimeOffset>();

            foreach (var stages in model.Data.Stages)
            {
                Console.WriteLine(string.Format(
                    "####################\n" +
                    "{0}\n" +
                    "####################", stages.Name));

                foreach (var week in stages.Weeks)
                {
                    if (DateTimeOffset.FromUnixTimeMilliseconds(week.EndDate) > DateTime.Now)
                    {
                        Console.WriteLine(string.Format(
                        "-------------\n" +
                        "{0} - Week ending {1}\n" +
                        "-------------", week.Name, DateTimeOffset.FromUnixTimeMilliseconds(week.EndDate)));

                        foreach (var match in week.Matches)
                        {
                            Console.WriteLine("Start date: {0}", match.StartDate.ToLocalTime());
                            dates.Add(match.StartDate.ToLocalTime());
                        }
                    }
                }
            }

            return dates;
        }
    }
}

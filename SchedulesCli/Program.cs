using System;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.MemoryStorage;

namespace SchedulesCli
{
    class Program
    {
        static async Task Main(string[] args)
        {
            BrowserStart.LaunchBrowser();

            GlobalConfiguration.Configuration
                .UseColouredConsoleLogProvider()
                .UseMemoryStorage();

            using (var server = new BackgroundJobServer())
            {
                var dates = await Matches.Dates();

                foreach (var date in dates)
                {
                    BackgroundJob.Schedule(() => BrowserStart.LaunchBrowser(), date);
                }
                Console.ReadLine();
            }
        }
    }
}

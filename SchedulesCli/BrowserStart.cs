using System.Diagnostics;

namespace SchedulesCli
{
    public class BrowserStart
    {
        public static void LaunchBrowser()
        {
            try
            {
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe2", "https://www.twitch.tv/overwatchleague");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                System.Console.WriteLine("Chrome not found. Falling back to Internet Explorer");
                Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe", "https://www.twitch.tv/overwatchleague");
            }
            catch (System.Exception)
            {

            }
        }
    }
}
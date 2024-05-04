using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWatch.Helpers
{
    public class DateTimeHelper
    {

        public static DateTime GetNow()
        {
            return ConfigHelper.Config.GetDateTimeNow();
        }

        public static string GetTimeNow()
        {
            return ConfigHelper.Config.GetDateTimeNow().ToString("HH:mm:ss");
        }

        public static string GetFullDate()
        {
            return ConfigHelper.Config.GetDateTimeNow().ToString("dddd, dd MMMM yyyy");
        }

        public static string GetTimeDifferenceMMSS(DateTime inputTime)
        {
            TimeSpan difference = DateTimeHelper.GetNow() - inputTime;
            return $"{Math.Abs(difference.Minutes):00}:{Math.Abs(difference.Seconds):00}";
        }

    }
}

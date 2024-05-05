using MarketWatch.Models;
using MarketWatch.Repositories.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWatch.Repositories.CalendarEconomic
{
    public class CalendarSoundControl
    {

        private static Dictionary<string, string> calendars = new Dictionary<string, string>();

        public static bool FlagAlreadyPlayed(CalendarEconomicModel calendarModel, int minutesBefore)
        {
            var ret = false;
            if (calendars.ContainsKey($"{calendarModel.UId()}-{minutesBefore}"))
            {
                ret = true;
            }
            else
            {
                ret = false;
            }

            calendars[$"{calendarModel.UId()}-{minutesBefore}"] = $"{calendarModel.UId()}-{minutesBefore}";
            return ret;
        }


    }
}

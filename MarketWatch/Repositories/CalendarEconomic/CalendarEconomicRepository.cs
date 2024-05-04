using MarketWatch.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWatch.Repositories.Calendar
{

    public class CalendarModelExt 
    { 
        public CalendarEconomicModel CalendarModel { get; set; }
        public Color color { get; set; }
        

        public bool IsEmpty()
        {
            return (CalendarModel == null);
        }

        public string FullTitle()
        {
            var fullTitle = "";
            if (CalendarModel != null)
            {
                var now = DateTimeHelper.GetNow();
                var newsNow = DateTime.ParseExact(CalendarModel.When, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                var preNews = newsNow.AddMinutes(-10);
                var prepreNews = newsNow.AddMinutes(-2);

                fullTitle = $"[{ newsNow.ToString("HH:mm") }] {CalendarModel.Title}";

                if (now >= preNews)
                {
                    if (now >= preNews)
                    {
                        color = Color.Yellow;
                    }
                    if (now >= prepreNews)
                    {
                        color = Color.Red;
                    }                    
                    if (now >= newsNow)
                    {
                        color = Color.Lime;
                    }

                    if (now <= newsNow)
                    {
                        var timeTo = DateTimeHelper.GetTimeDifferenceMMSS(newsNow);
                        fullTitle += $" | {timeTo}";
                    }
                }
                else
                {
                    color = Color.Gray;
                }
                
            }
            return fullTitle;
        }



    }

    public class CalendarEconomicRepository
    {

        public static CalendarModelExt NextEvent()
        {
            var calendarExt = new CalendarModelExt();
            var now = ConfigHelper.GetConfig().GetDateTimeNow();
            var calendars = CalendarLoader.GetCalendars();

            if (calendars.Count > 0)
            {
                var cal = calendars[0];

                // espera 1 minuto para remover a news....
                if (now >= cal.GetDateTimeFull().AddMinutes(1))
                {
                    CalendarLoader.Remove(cal);
                }

                // apresenta o calendario 10 minutos antes da noticia
                if (now >= cal.GetDateTimeFull().AddMinutes(-10) && now <= cal.GetDateTimeFull().AddMinutes(1))
                {
                    calendarExt.CalendarModel = cal;
                } else 
                {
                    calendarExt.CalendarModel = null;
                }

            }
            
            return calendarExt;
        }

    }
}

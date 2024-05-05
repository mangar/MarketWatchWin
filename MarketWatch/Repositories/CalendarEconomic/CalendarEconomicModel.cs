using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWatch.Repositories.Calendar
{

    public class RootObject
    {
        public List<CalendarEconomicModel> Items { get; set; }
    }

    public class CalendarEconomicModel
    {
        public string Country { get; set; }
        public string When { get; set; }
        public string Title {  get; set; }


        public DateTime GetDateTimeFull()
        {
            return DateTime.ParseExact(When, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
        }

        public string UId()
        {
            return $"{this.Country}-{this.When}-{this.Title}";
        }

    }


    public class CalendarLoader
    {
        private static List<CalendarEconomicModel> CalendarModels;

        public static List<CalendarEconomicModel> GetCalendars()
        {
            if (CalendarModels == null)
            {
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources/Data/calendar.json");
                string jsonData = File.ReadAllText(filePath);

                RootObject root = JsonConvert.DeserializeObject<RootObject>(jsonData);

                //CalendarModels = root.Items.ToList();
                CalendarModels = root.Items
                        .OrderBy(item => DateTime.ParseExact(item.When, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture))
                        .ToList();
            }

            return CalendarModels;
        }

        public static void Remove(CalendarEconomicModel calendar)
        {
            CalendarModels.Remove(calendar);
        }

    }

}

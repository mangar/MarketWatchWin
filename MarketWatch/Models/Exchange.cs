using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWatch.Models
{
    public class Exchange
    {
        public string Name { get; set; }
        public string Open{ get; set; }
        public string Close { get; set; }


        public string GetFullName()
        {
            return Name + ": " + Open + " ~ " + Close;
        }


        public DateTime OpenToday()
        {
            DateTime now = DateTime.Now;

            var exchanges = new ExchangeFactory().GetExchanges();

            var h = Open.Split(':')[0];
            var m = Open.Split(':')[1];

            return new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Int32.Parse(h), Int32.Parse(m), 0);
        }

        public DateTime CloseToday()
        {
            DateTime now = DateTime.Now;

            var exchanges = new ExchangeFactory().GetExchanges();

            var h = Close.Split(':')[0];
            var m = Close.Split(':')[1];

            return new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Int32.Parse(h), Int32.Parse(m), 0);
        }

        public string GetStatus()
        {
            var now = DateTime.Now;
            var openToday = OpenToday();
            var closeToday = CloseToday();
            var preOpenDateInit = openToday.AddMinutes(-10);

            if (now >= preOpenDateInit && now <= closeToday)
            {               
                if (now >= preOpenDateInit && now <= openToday)
                {
                    return "preopen";
                }

                var preCloseDateInit = closeToday.AddMinutes(-10);
                if (now >= preCloseDateInit && now <= closeToday)
                {
                    return "preclose";
                }


                return "open";
            }


            if (now < openToday.AddMinutes(-10) || now >= closeToday)
            {
                return "close";
            }

            return "undefined";
        }

    }
}

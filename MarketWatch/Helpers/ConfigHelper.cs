using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketWatch.Helpers
{

    public class Configuration
    {
        public Settings settings { get; set; }
        public DateTime StartDateTime { get; set; }


        public DateTime GetDateTimeNow()
        {
            if (settings.debugEnabled && !string.IsNullOrEmpty(settings.startDateTime))
            {
                try
                {
                    var startDateTime = DateTime.ParseExact(settings.startDateTime, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    TimeSpan difference = DateTime.Now - StartDateTime;
                    var ret = startDateTime.AddSeconds(difference.TotalSeconds);

                    return ret;
                }
                catch (FormatException)
                {
                    return DateTime.Now;
                }
            }
            else
            {
                return DateTime.Now;
            }
        }
    }

    public class Settings
    {
        public bool debugEnabled { get; set; }
        public string startDateTime { get; set; }        
    }

    public class ConfigHelper()
    {
        public static Configuration ?Config;
        
        public static Configuration LoadConfiguration()
        {
            if (Config == null)
            {
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources/config.json");
                string jsonData = File.ReadAllText(filePath);

                Configuration ?config = JsonConvert.DeserializeObject<Configuration>(jsonData);

                if (Config == null)
                {                    
                    Config = config;
                    Config.StartDateTime = DateTime.Now;
                }
            }
            return Config;
        }

    }




}

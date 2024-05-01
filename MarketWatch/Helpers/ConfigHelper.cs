using MarketWatch.Models;
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
        public Settings Settings { get; set; }

        public Features Features{ get; set; }

        public Exchange[] Exchanges { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime GetDateTimeNow()
        {
            if (Settings.DebugEnabled && !string.IsNullOrEmpty(Settings.StartDateTime))
            {
                try
                {
                    var startDateTime = DateTime.ParseExact(Settings.StartDateTime, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
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
        public bool DebugEnabled { get; set; }
        public string StartDateTime { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Version { get; set; }
    }

    public class Features
    {
        public bool FlagAlarms { get; set; }
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


        public static Configuration GetConfig() {
            return ConfigHelper.LoadConfiguration();
        }


        public static void SaveConfig()
        {
            ConfigHelper.Config.Settings.UpdatedAt = DateTime.Now;
            string jsonString = JsonConvert.SerializeObject(ConfigHelper.Config, Formatting.Indented);
            File.WriteAllText(@"Resources/config.json", jsonString);
        }


    }




}

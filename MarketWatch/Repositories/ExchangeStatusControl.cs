using MarketWatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWatch.Repositories
{
    public class ExchangeStatusControl
    {

        private static Dictionary<string, string> exchanges = new Dictionary<string, string>();

        public static bool IsStatusChanged(Exchange exchange)
        {
            var ret = false;
            if (exchanges.ContainsKey(exchange.Name))
            {
                var statusExchange = exchanges[exchange.Name];
                if (statusExchange == exchange.GetStatus())
                {
                    ret = false;
                }
                else
                {
                    ret = true;
                }
            }
            else 
            {
                ret = false;            
            }

            exchanges[exchange.Name] = exchange.GetStatus();
            return ret;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWatch.Models
{
    public class ExchangeFactory
    {

        public List<Exchange> GetExchanges() 
        {

            return new List<Exchange>
            {
                new Exchange { Name = "BR FUT",         Open = "09:00", Close = "17:00" },
                new Exchange { Name = "BR IBOV",        Open = "10:00", Close = "17:30" },
                new Exchange { Name = "US NYSE",        Open = "10:30", Close = "17:30" },
                new Exchange { Name = "|OPER| NASDAQ",  Open = "11:00", Close = "11:40" },
            };
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest.Library.TradeLoaders;
using System.Configuration;

namespace TechTest.Library
{
    public class TradeLoader
    {
        public IEnumerable<Trade> LoadTrades()
        {
            var trades = new List<Trade>();

            foreach (string key in ConfigurationManager.AppSettings)
            {
                string value = ConfigurationManager.AppSettings[key];
                string type = value.Substring(value.Length - 3);
                switch (type)
                {
                    case "xml":
                        trades.AddRange((new XmlTradeLoader()).LoadTrades(value));
                        break;
                    case "csv":
                        trades.AddRange((new CsvTradeLoader()).LoadTrades(value));
                        break;
                    case "pip":
                        trades.AddRange((new PipTradeLoader()).LoadTrades(value));
                        break;
                }
            }
            return trades;


        }
    }
}

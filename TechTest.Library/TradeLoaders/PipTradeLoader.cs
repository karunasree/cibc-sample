using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TechTest.Library.TradeLoaders
{
    public class PipTradeLoader
    {
      
        public IEnumerable<Trade> LoadTrades(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string tradeLine = reader.ReadLine();
                    var parts = tradeLine.Split('|');
                    var trade = new Trade
                    {
                        TradeType = parts[0],
                        Identifier = parts[1],
                        PaymentCurrency = parts[2],
                        Quantity = double.Parse(parts[3]),
                        Price = double.Parse(parts[4]),
                        Symbol = parts[5],
                        TradeDate = DateTime.Parse(parts[6]),
                    };

                    yield return trade;
                }
            }
        }
    }
    }

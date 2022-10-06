using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest.Library;



namespace TechTest
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var tradeLoader = new TradeLoader();
        //    foreach (var trade in tradeLoader.LoadTrades())
        //    {
        //        Console.WriteLine(trade);
        //    }

        //    Console.WriteLine("Press any key to exit...");
        //    Console.ReadKey();
        //}

        static void Main(string[] args)
        {
            var tradeLoader = new TradeLoader();

            Parallel.ForEach(tradeLoader.LoadTrades(), trade =>
            {
                Console.WriteLine(trade);
            });
            
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


    }
}

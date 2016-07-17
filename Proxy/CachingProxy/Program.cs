using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CachingProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //IStockService service = new RealStockService();
            IStockService service = new CachedStockService();
            UseStockService(service);
        }

        private static void UseStockService(IStockService service)
        {
            while (true)
            {
                Console.WriteLine("\nStock symbol:");
                string symbol = Console.ReadLine();

                var sw = Stopwatch.StartNew();
                var stock = service.GetStock(symbol);
                sw.Stop();

                Console.WriteLine("Stock: {0}", stock);
                Console.WriteLine("Time to get stock: {0}",
                    sw.ElapsedMilliseconds);
            }
        }
    }
}

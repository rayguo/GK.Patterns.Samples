using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CachingProxy
{
    class RealStockService : IStockService
    {
        public Stock GetStock(string symbol)
        {
            Thread.Sleep(500); // Simulate latency
            var price = new Random().Next(1000);
            Stock stock = new Stock { Symbol = symbol, Price = price };
            return stock;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CachingProxy
{
    class StockCache
    {
        private static StockCache _instance = new StockCache();

        private StockCache()
        {
            Stocks = new Dictionary<string, Stock>();
        }

        public static StockCache GetInstance()
        {
            return _instance;
        }

        public Dictionary<string, Stock> Stocks { get; private set; }
    }
}

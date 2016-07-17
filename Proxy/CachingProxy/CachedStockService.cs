using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CachingProxy
{
    class CachedStockService : IStockService
    {
        public Stock GetStock(string symbol)
        {
            // Try to get from cache
            var cache = StockCache.GetInstance();
            if (cache.Stocks.ContainsKey(symbol))
            {
                return cache.Stocks[symbol];
            }

            // Get from real service
            var stockService = new RealStockService();
            var stock = stockService.GetStock(symbol);

            // Put in cache
            cache.Stocks.Add(symbol, stock);
            return stock;
        }
    }
}

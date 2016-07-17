using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CachingProxy
{
    interface IStockService
    {
        Stock GetStock(string symbol);
    }
}

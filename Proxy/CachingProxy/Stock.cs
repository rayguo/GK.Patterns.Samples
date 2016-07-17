using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CachingProxy
{
    class Stock
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}",
                Symbol, Price.ToString("C"));
        }
    }
}

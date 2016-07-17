using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternLib
{
    class ShippedOrderState : OrderState
    {
        public ShippedOrderState(Order order) : base(order) { }
    }
}

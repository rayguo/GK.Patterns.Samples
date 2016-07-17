using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternLib
{
    class ReadyForShippingOrderState : OrderState
    {
        public ReadyForShippingOrderState(Order order) : base(order) { }

        public override void Ship()
        {
            Order.InternalShip();
            Order.OrderState = new ShippedOrderState(Order);
        }
    }
}

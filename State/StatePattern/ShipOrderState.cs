using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternLib
{
    class ShipOrderState : OrderState
    {
        public ShipOrderState(Order order) : base(order) { }

        public override void Ship()
        {
            //base.Ship();
        }
    }
}

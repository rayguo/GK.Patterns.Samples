using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternLib
{
    class SetDeliveryDetailsOrderState : OrderState
    {
        public SetDeliveryDetailsOrderState(Order order) : base(order) { }

        public override void SetDeliveryDetails()
        {
            Order.InternalSetDeliveryDetails();
            Order.OrderState = new ReadyForShippingOrderState(Order);
        }
    }
}

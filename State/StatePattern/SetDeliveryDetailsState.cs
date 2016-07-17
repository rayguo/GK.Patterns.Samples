using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternLib
{
    class SetDeliveryDetailsState : OrderState
    {
        public SetDeliveryDetailsState(Order order) : base(order) { }
    }
}

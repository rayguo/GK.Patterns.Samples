using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternLib
{
    class SelectingOrderState : OrderState
    {
        public SelectingOrderState(Order order) : base(order) { }

        public override void AddBook(string title)
        {
            Order.InternalAddBook(title);
        }

        public override void SubmitOrder()
        {
            Order.InternalSubmitOrder();
            Order.OrderState = new SetDeliveryDetailsOrderState(Order);
        }
    }
}

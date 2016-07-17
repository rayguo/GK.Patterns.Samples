using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternLib
{
    abstract class OrderState
    {
        protected Order Order { get; private set; }

        protected OrderState(Order order)
        {
            Order = order;
        }

        public virtual void AddBook(string title)
        {
            throw new InvalidOperationException("AddBook not valid for current state.");
        }

        public virtual void SubmitOrder()
        {
            throw new InvalidOperationException("SubmitOrder not valid for current state.");
        }

        public virtual void SetDeliveryDetails()
        {
            throw new InvalidOperationException("SetDeliveryDetails not valid for current state.");
        }

        public virtual void Ship()
        {
            throw new InvalidOperationException("Ship not valid for current state.");
        }
    }
}

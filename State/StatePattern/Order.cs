using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternLib
{
    public class Order
    {
        private readonly List<Book> _books = new List<Book>();

        internal OrderState OrderState { get; set; }

        public Order()
        {
            OrderState = new SelectingOrderState(this);
        }

        public void AddBook(string title)
        {
            OrderState.AddBook(title);
        }

        internal void InternalAddBook(string title)
        {
            _books.Add(new Book(title));
            Console.WriteLine("{0} added to order", title);
        }

        public void SubmitOrder()
        {
            OrderState.SubmitOrder();
        }

        internal void InternalSubmitOrder()
        {
            Console.WriteLine("Submitting order");
        }

        public void SetDeliveryDetails()
        {
            OrderState.SetDeliveryDetails();
        }

        internal void InternalSetDeliveryDetails()
        {
            Console.WriteLine("Supplying delivery info");
        }

        public void Ship()
        {
            OrderState.Ship();
        }

        internal void InternalShip()
        {
            Console.WriteLine("Shipping order");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            UseEnumState();
        }

        private static void UseEnumState()
        {
            var order = new Order();
            order.AddBook("The Hobbit");
            order.AddBook("Lord of the Rings");
            order.AddBook("The Return of the King");

            order.SubmitOrder();

            order.SetDeliveryDetails();

            //order.SubmitOrder(); // exception

            order.Ship();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StatePatternLib;

namespace StatePatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UseStatePattern();
        }

        private static void UseStatePattern()
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleClient.ProductService;
using Entities;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to get products");
            Console.ReadLine();

            Product[] products = null;
            using (var proxy = new ProductServiceClient())
            {
                products = proxy.GetProducts();
            }

            foreach (var p in products)
            {
                Console.WriteLine("{0} {1}", 
                    p.ProductId, p.ProductName);
            }

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}

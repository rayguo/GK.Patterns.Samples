using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.Patterns;
using Entities;

namespace Service.EF
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            using (var context = new NorthwindSlimContext())
            {
                var products = (from p in context.Products
                               orderby p.ProductName
                               select p).ToList();
                return products;
            }
        }
    }
}

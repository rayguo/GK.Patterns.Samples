using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.Patterns;
using Entities;
using System.Data.Entity;

namespace Service.EF
{
    public class ProductRepository : IProductRepository
    {
        private readonly INorthwindSlimContext _context;

        public ProductRepository(INorthwindSlimContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = (from p in _context.Products
                            orderby p.ProductName
                            select p).ToList();
            return products;
        }

        public Product GetProduct(int id)
        {
            var product = (from p in _context.Products
                           where p.ProductId == id
                           select p).SingleOrDefault();
            return product;
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Attach(product);
        }
    }
}

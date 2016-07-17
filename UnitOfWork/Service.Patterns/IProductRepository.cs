using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace Service.Patterns
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void UpdateProduct(Product product);
    }
}

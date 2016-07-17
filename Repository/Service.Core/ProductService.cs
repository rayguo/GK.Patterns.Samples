using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Service.Patterns;

namespace Service.Core
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        // IoC Container provides the configured repository

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}

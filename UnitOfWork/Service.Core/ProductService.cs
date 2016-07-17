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
        private readonly INorthwindUnitOfWork _unitOfWork;

        // IoC Container provides the configured repository

        public ProductService(INorthwindUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = _unitOfWork.ProductRepository.GetProducts();
            return products;
        }

        public Product GetProduct(int id)
        {
            var product = _unitOfWork.ProductRepository.GetProduct(id);
            return product;
        }
    }
}

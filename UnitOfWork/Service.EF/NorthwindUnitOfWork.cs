using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.Patterns;
using System.Data.Entity;

namespace Service.EF
{
    public class NorthwindUnitOfWork : INorthwindUnitOfWork
    {
        private readonly INorthwindSlimContext _context;
        private readonly IProductRepository _productRepository;

        public NorthwindUnitOfWork(INorthwindSlimContext context,
            IProductRepository productRepository)
        {
            _context = context;
            _productRepository = productRepository;
        }

        public IProductRepository ProductRepository
        {
            get { return _productRepository; }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}

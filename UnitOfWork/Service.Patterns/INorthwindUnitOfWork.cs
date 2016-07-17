using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Patterns
{
    public interface INorthwindUnitOfWork : IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
    }
}

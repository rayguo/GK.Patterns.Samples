using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entities;

namespace Service.EF
{
    public interface INorthwindSlimContext
    {
        IDbSet<Product> Products { get; set; }
        int SaveChanges();
    }
}

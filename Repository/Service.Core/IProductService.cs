using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.ServiceModel;

namespace Service.Core
{
    [ServiceContract(Namespace = "urn:dm:demos")]
    public interface IProductService
    {
        [OperationContract]
        IEnumerable<Product> GetProducts();
    }
}

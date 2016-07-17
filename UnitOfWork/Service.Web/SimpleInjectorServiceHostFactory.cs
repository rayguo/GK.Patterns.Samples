using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleInjector;
using CommonInstanceFactory.Extensions.Wcf;
using Service.Patterns;
using Service.EF;
using Service.Core;
using CommonInstanceFactory.Extensions.Wcf.SimpleInjector;
using System.ServiceModel;

namespace Service.Web
{
    public class SimpleInjectorServiceHostFactory : InjectedServiceHostFactory<Container>
    {
        protected override Container CreateContainer()
        {
            var container = new Container();
            container.Register<IProductRepository, ProductRepository>();
            container.Register<ProductService>();
            return container;
        }

        protected override ServiceHost CreateInjectedServiceHost
            (Container container, Type serviceType, Uri[] baseAddresses)
        {
            ServiceHost serviceHost = new SimpleInjectorServiceHost
                (container, serviceType, baseAddresses);
            return serviceHost;
        }
    }
}
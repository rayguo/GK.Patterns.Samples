Repository Pattern Demo

For this demo to work, you must first install SQL Server.
The connection string in wb.config specifies SQL Express, 
but you can change it to use standard SQL Server instead if you wish.

You must also create the NorthwindSlim database and run the a script
to create and populate the tables.  Download a zip file containing
the script from here: http://bit.ly/northwindslim.

Follow these steps to replicate the demo.

1. Add Service.Patterns class library to an emply VS solution.
   - Add an IProductRepository interface with the following method:
     IEnumerable<Product> GetProducts();

2. Add an Entities class library
   - Add a public Product class
   - Add the following properties:
     int ProductId
	 string ProductName

3. Add Service.Core class library
   - Reference System.ServiceModel
   - Reference the Service.Patterns and Entities projects
   - Add IProductService interface
     
    [ServiceContract(Namespace = "urn:dm:demos")]
    public interface IProductService
    {
        [OperationContract]
        IEnumerable<Product> GetProducts();
    }

   - Add ProductService class
	 > Add private readonly field:
	   IProductRepository _productRepository
	 > Add a ctor that accepts IProductRepository productRepository,
	   and sets _productRepository
	   - The IoC container will inject the registered repository
     > Implement IProductService
	   In GetProducts call _productRepository.GetProducts();

4. Add a Service.EF project
   - Add the Entity Framework NuGet package
   - Reference Entities and Service.Patterns projects
   - Add a NorthwindSlimContext class that extends DbContext
     > Add a ctor that calls base with the cn string name
	   - Add code to turn off code first migrations
	   - Add code to turn off proxy creation
	 > Override OnModelCreating
	   - Remove pluralizing table name convention
	 > Add a DbSet<Product> property:
	   public DbSet<Product> Products { get; set; }

5. Add an empty ASP.NET Web Application called Service.Web
   - Add the Entity Framework NuGet package
   - Add the CommonInstanceFactory.Extensions.Wcf.SimpleInjector NuGet package
   - Reference Service.Core, Service.EF, Service.Patterns projects
   - Add a blank Text file called Service.svc
     > Add the following:

	<%@ ServiceHost 
		Factory="Service.Web.SimpleInjectorServiceHostFactory" 
		Service="Service.Core.ProductService" %>

	- Add a new class: SimpleInjectorServiceHostFactory
	  > Extend InjectedServiceHostFactory
	    - Implement abstract methods:

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

	- Use the WCF Config Editor to add the Product Service
	  with basic http
	  > Add metadata behavior with HttpGetEnabled = true
	- Copy the content of app.config from Service.EF to web.config
	- Add the following connection strings section:

	  <connectionStrings>
		<add name="NorthwindSlimContext" 
			 providerName="System.Data.SqlClient" 
			 connectionString="Data Source=.\sqlexpress;Initial Catalog=NorthwindSlim;Integrated Security=True" />
      </connectionStrings>

	- Start the web app and browse to Service.svc to see the help page

6. Add a Console application called ConsoleClient
   - Reference the Entities project
   - Add a service reference, click Discover, name it ProductService
   - Add code to Program.Main to invoke the service operation
     to retrieve products

    static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to get products");
        Console.ReadLine();

        Product[] products = null;
        using (var proxy = new ProductServiceClient())
        {
            products = proxy.GetProducts();
        }

        foreach (var p in products)
        {
            Console.WriteLine("{0} {1}", 
                p.ProductId, p.ProductName);
        }

        Console.WriteLine("Press Enter to exit");
        Console.ReadLine();
    }

   - Run the web and the client simultaneously
     - You should see products displayed in the console.




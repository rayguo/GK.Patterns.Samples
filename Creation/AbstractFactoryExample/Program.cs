using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    // Example of ADO.NET's Abstract Factory pattern

    class Program
    {
        static void Main(string[] args)
        {
            DbProviderFactory factory = DbProviderFactories
                .GetFactory("System.Data.SqlClient");

            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = ConfigurationManager
                    .ConnectionStrings["Northwind"].ConnectionString;
                DbCommand command = connection.CreateCommand();
                command.CommandText = "select * from product";
                connection.Open();
                DbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0} {1} {2}", reader[0], 
                        reader[1], reader[2]);
                }
            }
        }
    }
}

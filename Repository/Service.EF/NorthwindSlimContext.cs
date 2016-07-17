using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Service.EF
{
    public class NorthwindSlimContext : DbContext
    {
        // Specify connection string name

        public NorthwindSlimContext()
            : base("Name=NorthwindSlimContext")
        {
            // Turn off code first migrations
            Database.SetInitializer<NorthwindSlimContext>
                (new NullDatabaseInitializer<NorthwindSlimContext>());

            // Turn off proxy creation
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Remove pluralizing table name convention
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

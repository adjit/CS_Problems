using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI_TestStore.Models
{
    public class WebAPI_TestStoreContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebAPI_TestStoreContext() : base("name=WebAPI_TestStoreContext")
        {
        }

        public System.Data.Entity.DbSet<WebAPI_TestStore.Models.Reservations> Reservations { get; set; }

        public System.Data.Entity.DbSet<WebAPI_TestStore.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<WebAPI_TestStore.Models.Hotel> Hotels { get; set; }
    }
}

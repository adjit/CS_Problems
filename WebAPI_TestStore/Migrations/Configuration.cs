namespace WebAPI_TestStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAPI_TestStore.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI_TestStore.Models.WebAPI_TestStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPI_TestStore.Models.WebAPI_TestStoreContext context)
        {
            context.Hotels.AddOrUpdate(x => x.ID,
                new Hotel() { ID = 1, Name = "Hotel Magical", Address = "123 Fairy Lane" },
                new Hotel() { ID = 2, Name = "Amiglia Hotel", Address = "456 Blonde Sreet"},
                new Hotel() { ID = 3, Name = "Motel Cascade", Address = "789 Tree Drive"}
            );

            context.Customers.AddOrUpdate(x => x.ID,
                new Customer() { ID = 1, Name = "Bob Hope"},
                new Customer() { ID = 2, Name = "James Dickens" },
                new Customer() { ID = 3, Name = "Steve Jones" }
            );

            context.Reservations.AddOrUpdate(x => x.ID,
                new Reservations() { ID = 1, CheckInDate = DateTime.Now, CheckOutDate = DateTime.Now, CustomerID = 1, HotelID = 1}
            );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

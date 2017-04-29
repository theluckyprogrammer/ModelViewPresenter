using Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public class MyDatabase : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public MyDatabase(string connectionString) : base(connectionString)
        {
              Database.SetInitializer<MyDatabase>(new MyDatabaseInitializer());
        }

    }

    public class MyDatabaseInitializer : DropCreateDatabaseAlways<MyDatabase>
    {
        protected override void Seed(MyDatabase context)
        {
            IList<Customer> defaultCustomers = new List<Customer>();
            defaultCustomers.Add(new Customer { FirstName = "Roman", LastName = "Polanski",  Address = "Mokra 5", JoinDate = DateTime.Now });
            defaultCustomers.Add(new Customer { FirstName = "Bruce", LastName = "Willis",Address="Krzywa 8", JoinDate = DateTime.Now });
            defaultCustomers.Add(new Customer { FirstName = "Tina", LastName = "Turner", Address = "Sztuczna 3",  JoinDate = DateTime.Now });


            foreach (Customer std in defaultCustomers)
                context.Customers.Add(std);

            base.Seed(context);
        }
    }
}

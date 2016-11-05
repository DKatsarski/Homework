using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace EntityFrameworkHW
{
    public static class DAO
    {
        public static void InsertCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentException(nameof(customer));
            }

            var context = new NorthwindEntities();
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public static void ModifyCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentException(nameof(customer));
            }

            var context = new NorthwindEntities();
            var customerWithId = context
                .Customers
                .FirstOrDefault(c => c.CustomerID == customer.CustomerID);

            if (customerWithId == null)
            {
                throw new ArgumentException("Customer does not exist.");
            }

            var values = context.Entry(customerWithId).CurrentValues;
            values.SetValues(customer);
            context.SaveChanges();
        }

        public static void DeleteCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentException(nameof(customer));
            }

            var context = new NorthwindEntities(); 
            var matchingCustomer = context
                .Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            context.Customers.Remove(matchingCustomer);
            context.SaveChanges();
        }

        public static IEnumerable<Order> FindsAllSalesByregionAndPeriod(string shipReagion, DateTime start, DateTime end)
        {
            var context = new NorthwindEntities();
            var orders = context.Orders
                .Where(o => o.OrderDate.HasValue && start <= o.OrderDate && o.OrderDate <= end)
                .Where(o => o.ShipRegion != null)
                .Where(o => o.ShipRegion == shipReagion)
                .ToList();
            return orders;
        }

        public static void CreateATwinConnectionString()
        {
            var northwidndTwinConnectionString = "northwindTwin";
            var context = new NorthwindEntities(northwidndTwinConnectionString);
            context.Database.CreateIfNotExists();
        }

        public static Customer GetById(string id)
        {
            
            var context = new NorthwindEntities();
            var customer = context
                .Customers
                .FirstOrDefault(c => c.CustomerID == id);
            return customer;
        }

        public static void TransferServer()
        {
            ServerConnection conn = new ServerConnection("Server=.;Database=Northwind;Integrated Security = true");
            Server server = new Server(conn);

            Database newdb = new Database(server, "NorthwindTwin");
            newdb.Create();

            Transfer transfer = new Transfer(server.Databases["Northwind"]);
            transfer.CopyAllObjects = true;
            transfer.CopyAllUsers = true;
            transfer.Options.WithDependencies = true;
            transfer.DestinationDatabase = newdb.Name;
            transfer.DestinationServer = server.Name;
            transfer.DestinationLoginSecure = true;
            transfer.CopySchema = true;
            transfer.CopyData = true;
            transfer.Options.ContinueScriptingOnError = true;
            transfer.TransferData();
        }
    }
}

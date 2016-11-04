using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}

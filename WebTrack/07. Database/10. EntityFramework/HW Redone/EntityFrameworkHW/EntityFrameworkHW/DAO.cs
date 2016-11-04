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
            Console.WriteLine("omg");
        }

    }
}

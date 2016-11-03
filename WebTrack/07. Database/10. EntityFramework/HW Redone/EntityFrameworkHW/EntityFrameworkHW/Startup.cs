using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHW
{
    public class Startup
    {
        static void Main()
        {

            using (var db = new NorthwindEntities())
            {
                var customerOrders = db
                    .Orders
                    .Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada")
                   .Select(o => o.Customer)
                   .Distinct()
                    .ToList();
                Console.WriteLine(customerOrders); 
            }
        }
    }
}

using CarDealer.Services.Models.Customers;
using CarDealer.Services.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Models.Customers
{
    public class AllCustomersModel
    {
        public IEnumerable<CustomerModel> Customers { get; set; }

        public OrderedDirection OrderedDirection { get; set; }
    }
}

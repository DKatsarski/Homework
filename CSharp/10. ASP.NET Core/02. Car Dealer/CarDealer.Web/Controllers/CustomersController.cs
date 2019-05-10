
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Services;
using CarDealer.Services.Models;

namespace CarDealer.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService customers;


        public CustomersController(ICustomerService customers)
        {

            this.customers = customers;
        } 
        public IActionResult All(string order)
        {
            var orderDirection = order.ToLower() == "ascending"
                ? OrderedDirection.Ascending
                : OrderedDirection.Descending;

            var result = this.customers.OrderedCustomers(orderDirection);

            return View(result);
        }
    }
}

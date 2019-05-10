
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Services;


namespace CarDealer.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService customers;


        public CustomersController(ICustomerService customers)
        {

            this.customers = customers;
        } 
        public IActionResult All(string id)
        {
            return null;
        }
    }
}

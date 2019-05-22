﻿
using CarDealer.Services;
using CarDealer.Services.Models;
using CarDealer.Web.Infrastructure.Extensions;
using CarDealer.Web.Models.Customers;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Web.Controllers
{
    [Route("customers")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService customers;


        public CustomersController(ICustomerService customers)
        {

            this.customers = customers;
        }

        [Route("all/{order}")]
        public IActionResult All(string order)
        {
            var orderDirection = order.ToLower() == "descending"
                ? OrderedDirection.Descending
                : OrderedDirection.Ascending;

            var customers = this.customers.Customers(orderDirection);

            return View(new AllCustomersModel
            {
                Customers = customers,
                OrderedDirection = orderDirection
            });
        }

        [Route("{id}")]
        public IActionResult TotalSales(int id)
        {
            return this.ViewOrNotFound(this.customers.TotalSalesById(id));
        }
    }
}

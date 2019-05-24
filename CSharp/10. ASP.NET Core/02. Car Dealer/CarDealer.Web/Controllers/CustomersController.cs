
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

        [Route(nameof(Create))]
        public IActionResult Create() => View();


        [HttpPost]
        [Route(nameof(Create))]
        public IActionResult Create(CustomerFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.customers.Create(
                model.Name,
                model.Birthday,
                model.IsYoungDriver);

            return RedirectToAction(nameof(All), new { order = OrderedDirection.Ascending });
        }

        [Route(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id)
        {
            var customer = this.customers.ById(id);

            if (customer == null)
            {

                return NotFound();
            }

            return View(new CustomerFormModel
            {
                Name = customer.Name,
                Birthday = customer.BirthDate,
                IsYoungDriver = customer.IsYoungDriver
            });
        }

        [HttpPost]
        [Route(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id, CustomerFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var customerExists = this.customers.Exists(id);


            if (!customerExists)
            {
                return NotFound();
            }

            this.customers.Edit(
            id,
          model.Name,
          model.Birthday,
          model.IsYoungDriver);

            return RedirectToAction(nameof(All), new { order = OrderedDirection.Ascending });

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

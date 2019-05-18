using CarDealer.Services;
using CarDealer.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService cars;

        public CarController(ICarService cars)
        {
            this.cars = cars;
        }

        IActionResult ByMake(string make)
        {
            var cars = this.cars.ByMake(make);

            return View(new CarModel
            {
                
            })
        }

    }
}

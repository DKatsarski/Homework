using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyOnlyCatServer.Data;
using MyOnlyCatServer.Models;

namespace MyOnlyCatServer.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(MyOnlyContext context)
        {
            this.Context = context;
        }


        public MyOnlyContext Context { get; set; }

        public IActionResult Index()
        {
            var cats = this.Context.Cats.ToList();

            return View(cats);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyOnlyCatServer.Data;
using MyOnlyCatServer.Model;

namespace MyOnlyCatServer.Controllers
{
    public class CatsController : Controller
    {

        public CatsController(MyOnlyContext context)
        {

            this.Context = context;
        }


        public MyOnlyContext Context { get; set; }

        public IActionResult Details(int id)
        {
            var cat = this.Context.Cats.Find(id);

            if (cat == null)
            {
                return NotFound();
            }

            return View(cat);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Cat model)
        {
            this.Context.Add(model);
            this.Context.SaveChanges();

            return RedirectToRoute("default", new {controller = "Home", action = "Index" });
        }
    }
}
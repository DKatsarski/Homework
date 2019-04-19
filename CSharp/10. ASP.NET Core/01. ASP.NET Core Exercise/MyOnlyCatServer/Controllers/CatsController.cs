using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyOnlyCatServer.Data;

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
    }
}
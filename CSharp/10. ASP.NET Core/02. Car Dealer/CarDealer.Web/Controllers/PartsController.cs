using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Services;
using Microsoft.AspNetCore.Mvc;
using CarDealer.Web.Models.Parts;

namespace CarDealer.Web.Controllers
{
    public class PartsController : Controller
    {
        private const int PageSize = 25;

        private readonly IPartService parts;

        public PartsController(IPartService parts)
        {
            this.parts = parts;
        }

        public IActionResult All(int page = 1)
        {
            var parts = this.parts.All(page, PageSize);

            return View(new PartPageListingModel
            {
                Parts = parts,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(this.parts.Total() / (double)PageSize)
            });
        }

        public IActionResult Create() => View();
    }
}
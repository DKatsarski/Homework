using CarDealer.Services;
using CarDealer.Web.Models.Suppliers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Controllers
{
    public class SuppliersController : Controller
    {

        private const string SuppliersView = "Suppliers";

        private readonly ISupplierService suppliers;

        public SuppliersController(ISupplierService supplierService)
        {
            this.suppliers = supplierService;
        }

        public IActionResult Local()
        {
            return View(SuppliersView, this.GetSuppliersModel(false));
        }

        public IActionResult Importers()
        {
            return View(SuppliersView, this.GetSuppliersModel(true));

        }

        private SuppliersModel GetSuppliersModel(bool importers)
        {
            var type = importers ? "Importer" : "Local";

            var suppliers = this.suppliers.All(importers);

            return new SuppliersModel
            {
                Type = type,
                Suppliers = suppliers
            };
        }
    }
}

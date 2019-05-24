using CarDealer.Services;
using CarDealer.Web.Infrastructure.Extensions;

using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Web.Controllers
{
    [Route("sales")]
    public class SalesController : Controller
    {
        private ISaleService sales;

        public SalesController(ISaleService sales)
        {
            this.sales = sales;
        }

        [Route("")]
        public IActionResult All()
        => View(this.sales.All());

        [Route("{id}")]
        public IActionResult Details(int id)
        {
            return this.ViewOrNotFound(this.sales.Details(id));
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Infrastructure.Extensions
{
    public static class ControllerExtension
    {
        public static IActionResult ViewOrNotFound(this Controller controller, object model)
        {
            if (model == null)
            {
                return controller.NotFound();
            }

            return controller.View(model);
        }
    }
}

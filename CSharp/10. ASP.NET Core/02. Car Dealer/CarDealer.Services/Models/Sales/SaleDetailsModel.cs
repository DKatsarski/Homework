using CarDealer.Services.Models.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Services.Models.Sales
{
    public class SaleDetailsModel : SaleListModel
    {
        public CarModel Car { get; set; }
    }
}

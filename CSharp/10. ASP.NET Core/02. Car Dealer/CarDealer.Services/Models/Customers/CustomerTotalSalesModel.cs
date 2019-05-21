using CarDealer.Services.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealer.Services.Models.Customers
{
    public class CustomerTotalSalesModel
    {
        public string Name { get; set; }


        public bool IsYoungDriver { get; set; }


        public IEnumerable<CarPriceModel> Boughtcars { get; set; }


        public decimal TotalMoneySpent
        {
            get
            {
                return this.Boughtcars.Sum(c => c.Price * (1 - (decimal)c.Discount))
                    * (this.IsYoungDriver ? 0.95m : 1);
            }
        }

    }
}

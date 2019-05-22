using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Services.Models.Sales
{
    public class SaleListModel : SaleModel
    {
        public string CustomerName { get; set; }

        public decimal DiscountedPrice => this.Price * (decimal)this.Discount;
    }
}

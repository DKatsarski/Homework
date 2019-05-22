﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Services.Models.Sales
{
    public class SaleListModel : SaleModel
    {
        public string CustomerName { get; set; }

        public bool IsYoungDriver { get; set; }


        public decimal DiscountedPrice => this.Price * ((decimal)this.Discount + (this.IsYoungDriver ? 0.05m : 0));
    }
}
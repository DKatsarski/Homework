﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealer.Data.Models
{
    public class Sale
    {

        public int Id { get; set; }


        [Range(0, 100)]
        public double Discount { get; set; }

        public int Car_Id { get; set; }


        public Car Car { get; set; }

        public int Customer_Id { get; set; }

        public Customer Customer { get; set; }


    }
}


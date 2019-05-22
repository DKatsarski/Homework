using CarDealer.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Services.Implementations
{
    public class SaleService
    {
        private readonly CarDealerDbContext db;

        public SaleService(CarDealerDbContext db)
        {
            this.db = db;
        }
    }
}

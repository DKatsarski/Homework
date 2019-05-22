using CarDealer.Data;
using CarDealer.Services.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealer.Services.Implementations
{
    public class SaleService : ISaleService
    {
        private readonly CarDealerDbContext db;

        public SaleService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SaleListModel> All()
        => this.db
            .Sales
            .Select(s => new SaleListModel
            {
                CustomerName = s.Customer.Name,
                Discount = s.Discount,
                IsYoungDriver = s.Customer.IsYoungDriver,
                Price = s.Car.Parts.Sum(p => p.Part.Price)
            })
            .ToList();
    }
}

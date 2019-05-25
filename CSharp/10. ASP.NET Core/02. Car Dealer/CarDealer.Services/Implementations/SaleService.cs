using CarDealer.Data;
using CarDealer.Services.Models.Cars;
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
            .OrderByDescending(s => s.Id)
            .Select(s => new SaleListModel
            {
                Id = s.Id,
                CustomerName = s.Customer.Name,
                Discount = s.Discount,
                IsYoungDriver = s.Customer.IsYoungDriver,
                Price = s.Car.Parts.Sum(p => p.Part.Price)
            })
            .ToList();

        public SaleDetailsModel Details(int id)
       => this.db
            .Sales
            .Where(s => s.Id == id)
            .Select(s => new SaleDetailsModel
            {
                Id = s.Id,
                CustomerName = s.Customer.Name,
                Discount = s.Discount,
                IsYoungDriver = s.Customer.IsYoungDriver,
                Price = s.Car.Parts.Sum(p => p.Part.Price),
                Car = new CarModel()
                {
                    Make = s.Car.Make,
                    Model = s.Car.Model,
                    TravelledDistance = s.Car.TravelledDistance
                }
            })
            .FirstOrDefault();
    }
}

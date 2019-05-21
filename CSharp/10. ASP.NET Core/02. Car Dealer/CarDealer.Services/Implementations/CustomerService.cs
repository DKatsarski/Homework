﻿namespace CarDealer.Services.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarDealer.Services.Models;
    using CarDealer.Services.Models.Cars;
    using Data;
    using Models.Customers;

    public class CustomerService : ICustomerService
    {
        private readonly CarDealerDbContext db;

        public CustomerService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CustomerModel> Customers(OrderedDirection order)
        {

            var customersQuery = this.db.Customers.AsQueryable();

            switch (order)
            {
                case OrderedDirection.Ascending:
                    customersQuery = customersQuery
                        .OrderBy(c => c.BirthDate)
                        .ThenBy(c => c.Name);
                    break;
                case OrderedDirection.Descending:

                    customersQuery = customersQuery
                        .OrderByDescending(c => c.BirthDate)
                        .ThenBy(c => c.Name);
                    break;
                default:
                    throw new InvalidOperationException($"Invalid order: {order}");
            }

            return customersQuery
                .Select(c => new CustomerModel
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate,
                    IsYoungDriver = c.IsYoungDriver
                })
                .ToList();
        }

        public CustomerTotalSalesModel TotalSalesById(int id)
       => this.db
            .Customers
            .Where(c => c.Id == id)
            .Select(c => new CustomerTotalSalesModel()
            {
                Name = c.Name,
                IsYoungDriver = c.IsYoungDriver,
                Boughtcars = c.Sales.Select(s => new CarPriceModel
                {
                    Price = s.Car.Parts.Sum(p => p.Part.Price),
                    Discount = s.Discount
                })

            })
            .FirstOrDefault();


    }
}

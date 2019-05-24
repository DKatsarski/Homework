namespace CarDealer.Services.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarDealer.Data.Models;
    using CarDealer.Services.Models;
    using CarDealer.Services.Models.Sales;
    using Data;
    using Models.Customers;

    public class CustomerService : ICustomerService
    {
        private readonly CarDealerDbContext db;

        public CustomerService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public CustomerModel ById(int id)
        {
            return this.db
                 .Customers
                 .Where(c => c.Id == id)
                 .Select(c => new CustomerModel
                 {
                     Id = c.Id,
                     Name  = c.Name,
                     BirthDate = c.BirthDate,
                     IsYoungDriver = c.IsYoungDriver
                 })
                 .FirstOrDefault();
        }

        public void Create(string name, DateTime birthday, bool isYoungDriver)
        {
            var customer = new Customer
            {
                Name = name,
                BirthDate = birthday,
                IsYoungDriver = isYoungDriver
            };

            this.db.Add(customer);
            this.db.SaveChanges();
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
                    Id = c.Id,
                    Name = c.Name,
                    BirthDate = c.BirthDate,
                    IsYoungDriver = c.IsYoungDriver
                })
                .ToList();
        }

        public void Edit(int id, string name, DateTime birthday, bool isYoungDriver)
        {
            var existingCustomer = this.db.Customers.Find(id);

            if (existingCustomer == null)
            {

                return;
            }

            existingCustomer.Name = name;
            existingCustomer.BirthDate = birthday;
            existingCustomer.IsYoungDriver = isYoungDriver;

            this.db.SaveChanges();
        }

        public bool Exists(int id)
        {
            return this.db.Customers.Any(c => c.Id == id);
        }

        public CustomerTotalSalesModel TotalSalesById(int id)
       => this.db
            .Customers
            .Where(c => c.Id == id)
            .Select(c => new CustomerTotalSalesModel()
            {
                Name = c.Name,
                IsYoungDriver = c.IsYoungDriver,
                Boughtcars = c.Sales.Select(s => new SaleModel
                {
                    Price = s.Car.Parts.Sum(p => p.Part.Price),
                    Discount = s.Discount
                })

            })
            .FirstOrDefault();


    }
}

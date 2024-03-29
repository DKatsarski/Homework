﻿namespace CarDealer.Services
{
    using Models;
    using Models.Customers;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICustomerService
    {
        IEnumerable<CustomerModel> Customers(OrderedDirection order);

        CustomerTotalSalesModel TotalSalesById(int id);

        void Create(string name, DateTime birthday, bool isYoungDriver);

        void Edit(int id, string name, DateTime birthday, bool isYoungDriver);


        CustomerModel ById(int id);

        bool Exists(int id);
    }
}

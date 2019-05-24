namespace CarDealer.Services
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

        void Create(string name, DateTime birthday);
    }
}

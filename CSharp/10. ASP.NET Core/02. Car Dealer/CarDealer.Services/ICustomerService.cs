namespace CarDealer.Services
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICustomerService
    {
        IEnumerable<CustomerModel> Customers(OrderedDirection order); 
    }
}

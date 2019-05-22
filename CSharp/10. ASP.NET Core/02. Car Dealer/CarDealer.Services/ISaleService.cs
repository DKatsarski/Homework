using CarDealer.Services.Models.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Services
{
    public interface ISaleService
    {
        IEnumerable<SaleListModel> All();

        SaleDetailsModel Details(int id);
    }
}

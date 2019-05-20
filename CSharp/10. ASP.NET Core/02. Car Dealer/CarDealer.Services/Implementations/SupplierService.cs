using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarDealer.Data;
using CarDealer.Services.Models;

namespace CarDealer.Services.Implementations
{
    public class SupplierService : ISupplierService
    {
        private readonly CarDealerDbContext db;

        public SupplierService(CarDealerDbContext db)
        {
            this.db = db;
        }




        public IEnumerable<SupplierModel> All(bool isImporter)
        => this.db
            .Suppliers
            .Where(s => s.IsImporter == isImporter)
            .Select(s => new SupplierModel
            {
                Id = s.Id,
                Name = s.Name,
                TotalParts = s.Parts.Count
            })
            .ToList();
    }
}

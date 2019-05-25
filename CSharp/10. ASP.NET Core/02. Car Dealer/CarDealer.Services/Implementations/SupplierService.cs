using CarDealer.Data;
using CarDealer.Services.Models.Suppliers;
using System.Collections.Generic;
using System.Linq;

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
            .OrderByDescending(s => s.Id)
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

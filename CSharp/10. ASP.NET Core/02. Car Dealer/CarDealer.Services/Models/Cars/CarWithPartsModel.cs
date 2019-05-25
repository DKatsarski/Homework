using System;
using System.Collections.Generic;
using System.Text;
using CarDealer.Services.Models.Parts;

namespace CarDealer.Services.Models.Cars
{
    public class CarWithPartsModel : CarModel
    {
        public IEnumerable<PartModel> Parts { get; set; }
    }
}

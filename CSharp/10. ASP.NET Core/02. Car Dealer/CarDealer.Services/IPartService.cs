using CarDealer.Services.Models.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Services
{
    public interface IPartService
    {
        IEnumerable<PartListingModel> All(int page = 1);
    }
}

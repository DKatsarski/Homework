using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(11)]
        public string Model { get; set; }

        
        public TransmissionType Transmission { get; set; }
        
        public ushort Year { get; set; }
        
        public decimal Price { get; set; }
        
        public int DealerId { get; set; }

        [Required]
        public virtual Dealer Dealer { get; set; }
        
        public int ManufacturerId { get; set; }

        [Required]
        public virtual Manufacturer Manufacturer { get; set; }
    }
}

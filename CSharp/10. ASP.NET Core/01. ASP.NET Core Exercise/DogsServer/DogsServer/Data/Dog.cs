using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogsServer.Data
{
    public class Dog
    {
        private const int StringMaxLength = 50;

        [Required]
        [MaxLength(StringMaxLength)]
        public int Id { get; set; }

        [Required]
        [MaxLength(StringMaxLength)]
        public string Name { get; set; }

        [Range(0, 30)]
        public int Age { get; set; }

        [Required]
        [MaxLength(StringMaxLength)]
        public string Breed { get; set; }

        [Required]
        [MaxLength(2000)]
        public string ImageUrl { get; set; }
    }
}

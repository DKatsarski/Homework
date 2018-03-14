using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatsServer.Data
{
    public class Cat
    {
        private const int StringMaxLength = 50;
        private const int StringMinLength = 1;

        public int Id { get; set; }

        [Required]
        [MinLength(StringMinLength)]
        [MaxLength(StringMaxLength)]
        public string Name { get; set; }

        [Required]
        [Range(0, 30)]
        public int Age { get; set; }

        [Required]
        [MinLength(StringMinLength)]
        [MaxLength(StringMaxLength)]
        public string Breed { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(2000)]
        public string ImageUrl { get; set; }
    }
}

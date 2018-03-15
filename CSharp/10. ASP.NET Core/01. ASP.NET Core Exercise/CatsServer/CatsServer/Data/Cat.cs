using System.ComponentModel.DataAnnotations;

namespace CatsServer.Data
{
    public class Cat
    {
        private const int StringMaxLength = 50;
        private const int StringMinLength = 1;

        public int Id { get; set; }

        [Required]
        [MaxLength(StringMaxLength)]
        public string Name { get; set; }

        [Required]
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

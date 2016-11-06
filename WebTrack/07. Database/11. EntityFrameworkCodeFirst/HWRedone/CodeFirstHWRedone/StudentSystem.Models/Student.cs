using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Models
{
    public class Student
    {


        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Index(IsClustered = false, IsUnique = true)]
        [StringLength(10, MinimumLength = 10)]
        [Range(0, int.MaxValue)]
        public int Number { get; set; }

        public Guid HomeworkId { get; set; }

        public virtual Homework Homework { get; set; }
    }
}


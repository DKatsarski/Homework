using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        

        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength =10)]
        public string Name { get; set; }

        public int Number { get; set; }

        public Guid HomeworkId { get; set; }

        public virtual Homework Homework { get; set; }
    }
}


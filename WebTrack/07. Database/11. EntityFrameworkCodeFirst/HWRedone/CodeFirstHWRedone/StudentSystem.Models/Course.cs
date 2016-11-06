using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Course
    {
        private ICollection<Student> student;

        public Course()
        {
            this.Id = Guid.NewGuid();
            this.student = new HashSet<Student>();
        }

        public Guid Id { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(54)]
        public string Name { get; set; }

        
        public string Description { get; set; }

        public string Materials { get; set; }

        public CoursesStatus Status { get; set; }

        public virtual ICollection<Student> Student
        {
            get { return this.student; }
            set { this.student = value; }
        }


    }
}

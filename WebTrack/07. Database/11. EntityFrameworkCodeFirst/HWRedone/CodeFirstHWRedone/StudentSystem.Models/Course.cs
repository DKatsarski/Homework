using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Course
    {
        public Course()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Materials { get; set; }

        public CoursesStatus Status { get; set; }
    }
}

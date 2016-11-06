using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class StudetsInCourse
    {
        private ICollection<Course> course;

        public StudetsInCourse()
        {
            this.course = new HashSet<Course>();
        }

        public int Id { get; set; }

        public virtual ICollection<Course> Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
    }
}

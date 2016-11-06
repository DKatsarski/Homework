using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    public class StudentDbContext : DbContext
    {
        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<StudetsInCourse> StudentsInCourses { get; set; }
    }
}

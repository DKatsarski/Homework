using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Course
    {
        private ICollection<Student> students;

        public Course()
        {
            this.students = new List<Student>();
        }

        public ICollection<Student> Students { get; private set; } //maybe shoudl be protected? 

    }
}

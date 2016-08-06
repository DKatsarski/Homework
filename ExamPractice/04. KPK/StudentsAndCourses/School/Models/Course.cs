using School.Contracts;
using School.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course : ICourse
    {
        ICollection<IStudent> students;

        public Course()
        {
            this.students = new List<IStudent>();
        }

        public ICollection<IStudent> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                Validator.CheckTheCourseCapacity(students);

                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            Validator.CheckTheCourseCapacity(students);

            students.Add(student);

        }

        public void RemoveStudent(Student student)
        {
            Validator.CheckTheCourseCapacity(students);

            students.Remove(student);
        }
    }
}

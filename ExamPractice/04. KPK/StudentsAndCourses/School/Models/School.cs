using School.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School : ISchool
    {
        ICollection<ICourse> courses;
        ICollection<IStudent> students; //should refactor the interface

        public School()
        {
            this.courses = new List<ICourse>();
            this.students = new List<IStudent>();
        }
    

        public ICollection<ICourse> Courses
        {
            get
            {
                if (this.courses == null)
                {
                    this.courses = new List<ICourse>();
                }

                return new List<ICourse>(this.courses);
            }
        }

        public ICollection<IStudent> Students
        {
            get
            {
                return new List<IStudent>(this.students);
            }
        }

        public void AdmitStudent(Student student)
        {
            students.Add(student);
        }

    }
}

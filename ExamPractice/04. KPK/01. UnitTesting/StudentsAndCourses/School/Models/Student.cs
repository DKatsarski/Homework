using School.Contracts;
using School.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : IStudent
    {
        private string name;
        private int number;

        public Student(string name, int number)
        {
            Validator.CheckIfItIsNullOrEmpty(name);
            Validator.CheckIfItIsOutOfRange(number);
            this.name = name;
            this.number = number;
        }


        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfItIsNullOrEmpty(name);

                this.name = value;
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                Validator.CheckIfItIsOutOfRange(number);

                this.number = value;
            }
        }

        public void JoinCourse(ICourse course)
        {
            course.AddStudent(this);
        }

        public void LeaveCourse(ICourse course)
        {
            course.RemoveStudent(this);
        }
    }
}

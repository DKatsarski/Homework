using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Contracts;
using UnitTesting.Models.Base;
using UnitTesting.Utils;

namespace UnitTesting
{
    public class Student : BaseNameableObject, IStudent
    {
        private int id;

        public Student(string name, int id)
            : base(name)
        {
        }

        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public bool JoinCourse(ICourse course)
        {
            if (Validator.CheckIfObjectIsNull(course))
            {
                throw new ArgumentNullException();
            }

            course.AddStudentToCourse(this);

            return true;
        }

        public bool LeaveCourse(ICourse course)
        {
            if (Validator.CheckIfObjectIsNull(course))
            {
                throw new ArgumentNullException();
            }

            course.RemoveStudentFromCourse(this);

            return true;
        }
    }
}

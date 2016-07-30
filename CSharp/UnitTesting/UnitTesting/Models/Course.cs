using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Contracts;
using UnitTesting.Exceptions;
using UnitTesting.Models.Base;
using UnitTesting.Utils;

namespace UnitTesting
{
    public class Course : BaseNameableObject, ICourse
    {
      private int maximumCapacityInStudents;

        private ICollection<IStudent> students = new HashSet<IStudent>();

        public Course(string name, int maximumCapacityInStudents)
            : base(name)
        {
            this.maximumCapacityInStudents = maximumCapacityInStudents;
        }

        public ICollection<IStudent> Students
        {
            get
            {
                if (this.students == null)
                {
                    this.students = new HashSet<IStudent>();
                }

                return new HashSet<IStudent>(this.students);
            }

            private set
            {
                this.students = value;
            }
        }

        /// <summary>
        /// Validate the input, throw appropriate exception 
        /// or add the student to this course.
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool AddStudentToCourse(IStudent student)
        {
            if (Validator.CheckIfObjectIsNull(student))
            {
                throw new ArgumentNullException();
            }

            if (this.students.Count == this.maximumCapacityInStudents)
            {
                throw new CourseException(CourseException.CourseOverCapacityErrorMessage);
            }

            if (this.students.Contains(student))
            {
                throw new CourseException(CourseException.DuplicateStudentErrorMessage);
            }

            this.students.Add(student);

            return true;
        }
        
        /// <summary>
        /// Should throw on Null or not existing input
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool RemoveStudentFromCourse(IStudent student)
        {
            if (Validator.CheckIfObjectIsNull(student))
            {
                throw new ArgumentNullException();
            }

            if (!this.students.Contains(student))
            {
                throw new CourseException(CourseException.StudentNotFoundErrorMessage);
            }

            this.students.Remove(student);

            return true;
        }
    }
}

namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public abstract class Course
    {
        public Course(string name)
        {
            if (name == string.Empty || name == null)
            {
                throw new ArgumentNullException("Invalid name!");
            }

            this.Name = name;
        }

        public Course(string courseName, string teacherName)
            : this(courseName)
        {
            if (teacherName == string.Empty || teacherName == null)
            {
                throw new ArgumentNullException("Invalid teacherName!");
            }

            this.TeacherName = teacherName;
        }

        public Course(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            if (students.Count == 0 || students == null)
            {
                throw new ArgumentNullException("Invalid list of students - empty or null!");
            }

            this.Students = students;
        }

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public IList<string> Students { get; set; }
        
        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}

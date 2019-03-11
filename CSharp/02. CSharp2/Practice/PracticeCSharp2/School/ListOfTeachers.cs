using System;
using System.Collections.Generic;

namespace School
{
    public class ListOfTeachers
    {
        private List<string> teachers;

        public ListOfTeachers()
        {
            this.teachers = new List<string>();
        }

        public IEnumerable<string> Teachers
        {
            get
            {
                return this.teachers;
            }

        }


        public void AddTeacher(string name)
        {
            teachers.Add(name);
        }

    }
}

using School;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Numbers_in_Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfTeachers = new ListOfTeachers();

            listOfTeachers.AddTeacher("Gosho Petrov");

            foreach (var teacher in listOfTeachers.Teachers)
            {
                Console.WriteLine(teacher);
            }
            
        }
    }
}
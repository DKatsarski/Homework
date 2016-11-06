using StudentSystem.Data;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Client
{
    class Startup
    {
        public static void Main()
        {
            var db = new StudentDbContext();

            var student = new Student
            {
                Name = "Pesho Peshov",
                Number = 1234,

            };

            db.Students.Add(student);
            db.SaveChanges();

            Console.WriteLine(db.Students.Count());
        }
    }
}

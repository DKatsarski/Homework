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
                Name = "Traicho Peshov",
                Number = 1234,
                Homework = new Homework()
                {
                    Content = "Math",
                    TimeSent = new DateTime(2016, 1, 12)
                }



            };

            db.Students.Add(student);
            db.SaveChanges();

            Console.WriteLine(db.Students.Count());

            Console.WriteLine(db.Homeworks.Count( ));

            //var homework = new Homework()
            //{
                
            //}
        }
    }
}

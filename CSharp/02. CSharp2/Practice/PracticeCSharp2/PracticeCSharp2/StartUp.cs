using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public static class StartUp
    {
        static void Main(string[] args)
        {


            DateTime date = DateTime.Now;
            DateTime birthDay = DateTime.Parse("02/14/1988");
            var years = date.Year - birthDay.Year;

            Console.WriteLine(years);

        }
    }
}
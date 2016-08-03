using System;

using System.Globalization;
using System.Threading;

namespace BirthDate
{
    class BirthDate
    {
        static void Main(string[] args)
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please, enter your birthdate in format MM/DD/YYYY: ");
            string date = Console.ReadLine();
            DateTime birthDate = Convert.ToDateTime(date);
            DateTime now = DateTime.Now;
            double days = now.Subtract(birthDate).TotalDays;
            double yourTrueYears = days / 365;
            int yourYears = (int)yourTrueYears;
            Console.WriteLine("Your age is {0} and in ten years time will be {1}. Good luck!", yourYears, (yourYears + 10));

        }
    }
}

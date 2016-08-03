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
            string date = Console.ReadLine();
            DateTime birthDate = Convert.ToDateTime(date);
            DateTime now = DateTime.Now;
            double days = now.Subtract(birthDate).TotalDays;
            double yourTrueYears = days / 365;
            int yourYears = (int)yourTrueYears;
            Console.WriteLine(yourYears);
            Console.WriteLine((yourYears + 10));
            // http://stackoverflow.com/questions/673476/age-in-years-from-datetime-date-of-birth - toq e za da se pryrne godinite w konkretni dni
            // http://stackoverflow.com/questions/4181942/convert-double-to-int - toq e za da se prewyrne ot double kym int
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProblem3_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            double result = 0;
            double divisor = 0;

            if (b == 3)
            {
                result = a + c;
            }
            else if (b == 6)
            {
                result = a * c;
            }
            else if (b == 9)
            {
                result = a % c;
            }

            if (result % 3 == 0)
            {
                divisor = result / 3;
            }
            else
            {
                divisor = result % 3;
            }
            Console.WriteLine(divisor);
            Console.WriteLine(result);
        }
    }
}

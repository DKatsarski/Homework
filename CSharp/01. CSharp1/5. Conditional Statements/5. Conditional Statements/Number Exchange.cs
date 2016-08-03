using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
            else if (a == b)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            decimal sum = 0;
            for (int i = 0; i < 80000000; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            DateTime finishTime = DateTime.Now;

            Console.WriteLine(finishTime - startTime);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            DateTime startTime = DateTime.Now;
            decimal operationsToCalculate = 0;

            for (int i = 0; i < 80000000; i++)
            {
                operationsToCalculate += i;
            }

            Console.WriteLine(operationsToCalculate);

            DateTime finishTime = DateTime.Now;

            TimeSpan usedTimeForTheOperation = finishTime - startTime;

            Console.WriteLine(usedTimeForTheOperation);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PritnStats
{
    class Program
    {
        static void Main()
        {
            double[] array = { 1, 2, 3, 4};
            var index = 4;

            var printer = new StatisticsOperator();
            printer.PrintStatistics(array, index);
        }
    }
}

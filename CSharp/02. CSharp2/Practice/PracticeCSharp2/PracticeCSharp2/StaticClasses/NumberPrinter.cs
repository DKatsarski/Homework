using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public static class NumberPrinter
    {
        public static void PrintUpToANumber(int number)
        {
            for (int i = 0; i < number + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

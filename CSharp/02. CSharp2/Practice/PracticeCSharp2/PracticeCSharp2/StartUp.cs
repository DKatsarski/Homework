using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine("please, input two numbers to be summed:");
            Console.WriteLine();

            int numberToBeSummed = int.Parse(Console.ReadLine());
            int secondNumberToBeSummed = int.Parse(Console.ReadLine());

            int result = SumNumbers.Sum(numberToBeSummed, secondNumberToBeSummed);

            Console.WriteLine(result);

            //NumberPrinter.PrintUpToANumber(5);

        }
    }
}

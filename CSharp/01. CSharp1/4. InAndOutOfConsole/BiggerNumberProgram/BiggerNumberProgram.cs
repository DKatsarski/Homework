using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumberProgram
{
    class BiggerNumberProgram
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            decimal firstNum = decimal.Parse(inputStr);
            inputStr = Console.ReadLine();
            int secondNum = int.Parse(inputStr);
            decimal greater = Math.Max(firstNum, secondNum);
            Console.WriteLine(greater);
        }

    }
}

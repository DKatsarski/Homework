using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCountDevidedBy5
{
    class NumberCountDevidedBy5
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int numberCount = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                { 
                   numberCount++;
                    
                }
            }

            Console.WriteLine(numberCount);
        }
    }
}

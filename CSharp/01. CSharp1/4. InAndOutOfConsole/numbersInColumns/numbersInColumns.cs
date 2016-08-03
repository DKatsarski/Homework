using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersInColumns
{
    class numbersInColumns
    {
        static void Main(string[] args)
        {
            Console.Write("Write first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Write second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Write third negative number: ");
            double thridNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Your numbers are:\n{0, -10:X}|{1, -10:F2}|{2, -10:F2}", firstNumber, secondNumber, thridNumber );
            Console.ReadLine();
            //{ 0:X, -10}|{ 1:F2, -10}|{ 2:F2, -10}


        }
    }
}

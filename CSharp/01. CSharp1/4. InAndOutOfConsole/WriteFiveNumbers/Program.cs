using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.NumPad0 | keyPressed.Key == ConsoleKey.NumPad1 | keyPressed.Key == ConsoleKey.NumPad2 | keyPressed.Key == ConsoleKey.NumPad3 | keyPressed.Key == ConsoleKey.NumPad4 | keyPressed.Key == ConsoleKey.NumPad5 | keyPressed.Key == ConsoleKey.NumPad6
                | keyPressed.Key == ConsoleKey.NumPad7 | keyPressed.Key == ConsoleKey.NumPad8 | keyPressed.Key == ConsoleKey.NumPad9 | keyPressed.Key == ConsoleKey.Decimal)
            {
                Console.Write("please, enternumber: ");
                double firstNumber = double.Parse(Console.ReadLine());
                
                Console.Write("please, enternumber: ");
                double secondNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(firstNumber + secondNumber);
            }
            else
            {
                Console.WriteLine("please, write a number again");
            }
            
        }
    }
}

//using System;
//namespace DivisibleBy5
//{
//    class AllDivisibelBy5
//    {
//        static void Main()
//        {

//            double number;
//            double asdf;
//            double fdsa;
//            string a = Console.ReadLine();
//            string b = Console.ReadLine();

//            //string c = Console.ReadLine();
//            //string d = Console.ReadLine();
//            //string e = Console.ReadLine();

//            if (double.TryParse(a, out number))
//            {
//                asdf = Convert.ToDouble(a);
//                //double aa = double.Parse(a);
//            }
//            else
//            {
//                Console.Write("Please, try entering the number again: ");


//            }

//            if (double.TryParse(b, out number))
//            {
//                fdsa = Convert.ToDouble(b);

//                // double bb = double.Parse(b);
//            }
//            else
//            {
//                Console.Write("Please, try entering the number again: ");
//            }

//            Console.WriteLine(asdf + fdsa);
//            //Console.WriteLine(a + b + c + d + e);
//        }
//    }
//}

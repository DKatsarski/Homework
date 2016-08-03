using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnSqrt();

        }

        static void ReturnSqrt()
        {

            try
            {
                double input = double.Parse(Console.ReadLine());
                string asdf = Math.Sqrt(input).ToString("F3");
                if (asdf == "NaN")
                {
                    throw new System.FormatException();
                }
                else
                {
                    Console.WriteLine(asdf);
                }
            }
            catch (FormatException exc)
            {

                Console.WriteLine("Invalid number");
                
            }
            finally
            {
                Console.WriteLine("Good bye");

            }

        }
    }
}

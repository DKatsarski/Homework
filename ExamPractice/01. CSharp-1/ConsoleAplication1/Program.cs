using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int width = 2 * n + 1;

            for (int row = 0; row < n; row++)
            {
                Console.Write(new string('#', row));
                Console.Write('\\');
              

                int spaceLeft = width - row - row - 1 - 1 - d - d;
                if (spaceLeft >= 2)
                {
                    Console.Write(new string(' ', d));
                    Console.Write('\\');
                    Console.Write(new string('.', spaceLeft - 2));
                    Console.Write('/');
                    Console.Write(new string(' ', d));
                }
                else
                {
                    Console.Write(new string(' ', width - row - row - 2));
                }
              

                Console.Write('/');
                Console.Write(new string('#', row));

              

                Console.WriteLine();
            }

            Console.WriteLine(new string('#', n) + 'X' + new string('#', n));


            for (int row = n - 1; row >= 0; row--)
            {
                Console.Write(new string('#', row));
                Console.Write('/');


                int spaceLeft = width - row - row - 1 - 1 - d - d;
                if (spaceLeft >= 2)
                {
                    Console.Write(new string(' ', d));
                    Console.Write('/');
                    Console.Write(new string('.', spaceLeft - 2));
                    Console.Write('\\');
                    Console.Write(new string(' ', d));
                }
                else
                {
                    Console.Write(new string(' ', width - row - row - 2));
                }


                Console.Write('\\');
                Console.Write(new string('#', row));



                Console.WriteLine();
            }
        }
    }
}

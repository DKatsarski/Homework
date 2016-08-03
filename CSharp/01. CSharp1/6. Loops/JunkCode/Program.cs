using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Calculate
{

    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int width = (x + x) + ((x / 2) + 1) + ((x / 2) + 1) - 3;
            int hornslength = x / 2;
            int middleDots = width - 2 * (x / 2 + 1);
            Console.Write(new string('.', hornslength));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.WriteLine(new string('.', hornslength));
            middleDots -= 2;

            int firstHornDots = x / 2 - 1;
            int dotsAfterHorn = 0;

            for (int i = 1; i < x - 1; i++)
            {
                if (i <= x / 2)
                {
                    Console.Write(new string('.', firstHornDots));
                    Console.Write('*');
                    Console.Write(new string('.', dotsAfterHorn));
                    firstHornDots--;
                    dotsAfterHorn++;
                }
                else
                {
                    Console.Write(new string('.', hornslength));
                }
                Console.Write(new string('.', hornslength));

                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', middleDots));
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.Write(new string('.', hornslength));

                middleDots -= 2;
                Console.WriteLine();
            }
            Console.Write(new string('.', width / 2));
            Console.Write("*");
            Console.WriteLine(new string('.', width / 2));

            int leftRightDots = x - 2;
            middleDots = 1;
            for (int i = 0; i < x - 1; i++)
            {

                Console.Write(new string('.', hornslength));
                Console.Write(new string('.', leftRightDots));
                Console.Write("*");
                Console.Write(new string('.', middleDots));
                Console.Write("*");
                Console.Write(new string('.', leftRightDots));
                Console.Write(new string('.', hornslength));

                leftRightDots--;
                middleDots += 2;
                Console.WriteLine();
            }

            middleDots -= 4;
            for (int i = 1; i < x - 1; i++)
            {
                Console.Write(new string('.', hornslength));

                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', middleDots));
                Console.Write("*");
                Console.Write(new string('.', i));

                Console.Write(new string('.', hornslength));

                middleDots -= 2;
                Console.WriteLine();
            }

            Console.Write(new string('.', width / 2));
            Console.Write("*");
            Console.WriteLine(new string('.', width / 2));





        }
    }
}

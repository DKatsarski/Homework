using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int aa = a - 1;


            long[] b =  {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765,
                10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578,
                5702887, 9227465, 14930352, 24157817, 39088169, 63245986, 102334155, 165580141, 267914296, 433494437,
                1134903170, 1836311903, 2971215073, 4807526976, 7778742049 };
            int zero = 0;


            for (int i = 0; i <= aa; i++)
            {
                
                    Console.Write((b[zero++]));
                if (zero <= aa && i != aa)
                {
                    Console.Write(", ");

            }

        }
    }
}
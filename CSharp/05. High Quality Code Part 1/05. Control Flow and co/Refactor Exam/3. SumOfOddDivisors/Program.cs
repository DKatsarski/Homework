using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SumOfOddDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = 0;


            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    if (i % j == 0 && j % 2 != 0)
                    {
                        
                            result += j;
                        

                    }
                 
                    



                }
            }
            Console.WriteLine(result);
        }
    }
}

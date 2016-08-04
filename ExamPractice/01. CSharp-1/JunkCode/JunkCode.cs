using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TextToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i);
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
 
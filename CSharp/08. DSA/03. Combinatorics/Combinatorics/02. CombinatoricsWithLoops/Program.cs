using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CombinatoricsWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var counter = 0;
            char ch = '*';

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ch)
                {
                    counter++;
                }
            }

            int reslut = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        reslut++;
                    }
                }
            }
            Console.WriteLine(reslut);
        }
    }
}

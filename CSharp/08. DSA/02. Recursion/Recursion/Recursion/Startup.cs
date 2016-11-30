using System;

namespace Recursion
{
    public class Startup
    {
        static void Main()
        {
            // 01. Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.

            int input = int.Parse(Console.ReadLine());
            int loopNumber = input;
            NestedLoops(input, loopNumber);
        }

        public static void NestedLoops(int n, int loopNumber, string vector = "",  int counter = 1)
        {
            if (n == 0)
            {
                Console.WriteLine(vector);
                return;
            }

            NestedLoops(n - 1, loopNumber, vector + (counter));

            for (int i = 0; i < loopNumber - 1; i++)
            {
                NestedLoops(n - 1, loopNumber, vector + (counter += 1));
            }
        }
    }
}

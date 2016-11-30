using System;

namespace Recursion
{
    public class Startup
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int loopNumber = input;
            NestingLoops(input, loopNumber);
        }

        public static void NestingLoops(int n, int loopNumber, string vector = "",  int counter = 1)
        {
            if (n == 0)
            {
                Console.WriteLine(vector);
                return;
            }

            NestingLoops(n - 1, loopNumber, vector + (counter));

            for (int i = 0; i < loopNumber - 1; i++)
            {
                NestingLoops(n - 1, loopNumber, vector + (counter += 1));
            }
        }
    }
}

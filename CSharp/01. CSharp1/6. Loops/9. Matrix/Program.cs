using System;

namespace _9.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[n, n];
            for (int x = 1; x <= n; x++)
            {
                Console.Write("{0} ", x);
                for (int y = x + 1; y <= n + (x - 1); y++)
                {
                    Console.Write("{0} ", y);
                }
                Console.WriteLine();
            }
        }
    }
}

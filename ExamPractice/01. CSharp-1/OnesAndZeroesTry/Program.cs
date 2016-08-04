using System;

namespace OnesAndZeroesTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2).PadLeft(32, '0');

            //drawing with string 
            string[] one = { ".#.",
                             "##.",
                             ".#.",
                             ".#.",
                             "###" };

            string[] zero = { "###",
                              "#.#",
                              "#.#",
                              "#.#",
                              "###" };

            for (int row = 0; row < zero.Length; row++)
            {
                for (int col = 16; col < binary.Length; col++)
                {
                    if (binary[col] == '1')
                    {
                        Console.Write(one[row]);
                    }
                    else
                    {
                        Console.Write(zero[row]);
                    }
                    if (col < binary.Length - 1)
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

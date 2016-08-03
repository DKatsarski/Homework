using System;

namespace UnicodeSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = (char)33;
            for (int i = 0; i <= 93; i++)
            {
                Console.Write(a++);
            }
            Console.ReadLine();
        }
    }
}

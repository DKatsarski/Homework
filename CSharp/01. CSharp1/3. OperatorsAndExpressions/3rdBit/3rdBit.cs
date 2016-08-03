using System;


namespace _3rdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if ((n & 8) == 8)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
           
        }
    }
}

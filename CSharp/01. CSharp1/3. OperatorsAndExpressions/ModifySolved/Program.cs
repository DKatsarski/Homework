using System;


namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {


            ulong a = ulong.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            if (v == 0)
            {
                ulong umask = (ulong)~(1 << p);   //0010 0101 1101
                ulong bit1 = a & umask;           //1111 1011 1111
                Console.WriteLine(bit1);
            }
            if (v == 1)
            {
                ulong mask = (ulong)v << p;       //0010 0101 1101
                ulong bit = a | mask;             //0000 0100 0000
                Console.WriteLine(bit);
            }



        }
    }
}

using System;

namespace NBit
{
    class NBit
    {
        static void Main(string[] args)
        {
            long p = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long mask = 1 << n;
            long nAndMask = p & mask;
            long findBit = nAndMask >> n;
            Console.WriteLine(findBit);

        }
    }
}

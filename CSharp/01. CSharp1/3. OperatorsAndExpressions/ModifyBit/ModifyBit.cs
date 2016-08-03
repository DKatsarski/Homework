using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            long mask = v << p;
            long nAndMask = n & mask;
            long findBit = nAndMask >> p;
            Console.WriteLine(findBit);
            // 1010
            // 0001

        }
    }
}

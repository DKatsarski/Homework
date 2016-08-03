using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteTheBiggestNumber
{
    class WriteTheBiggestNumber
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int biggestNumber = Math.Max(a, b);
            int biggestNumber1 = Math.Max(b, c);
            int biggestNumber2 = Math.Max(c, d);
            int biggestNumber3 = Math.Max(d, e);
            int omg = Math.Max(biggestNumber, biggestNumber1);
            int omg1 = Math.Max(biggestNumber1, biggestNumber2);
            int omg2 = Math.Max(biggestNumber2, biggestNumber3);
            int aaa = Math.Max(omg, omg1);
            int aaa1 = Math.Max(omg1, omg2);
            int reallyBigNumber = Math.Max(aaa, aaa1);
            Console.WriteLine(reallyBigNumber);
        }
    }
}

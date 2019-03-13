using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class PracticeCSharp2

    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int result = 0;

            int biggerNumberToBeUsedInTheForCycle = Math.Max(n, p);
            int lowerNumberToBeUsedInTheForCycle = Math.Min(n, p);

            int factorielBig = biggerNumberToBeUsedInTheForCycle;
            int factorielLow = lowerNumberToBeUsedInTheForCycle;

            for (int i = biggerNumberToBeUsedInTheForCycle - 1; i >= 1; i--)
            {
                factorielBig *= i;

                if (factorielLow > i)
                {
                    factorielLow *= i;
                }
            };

            result = factorielBig / factorielLow;

            Console.WriteLine(result);
        }
    }
}
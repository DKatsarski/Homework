using System;
using System.Numerics;
using System.Linq;

namespace _2.Two_Girls__One_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            int mollyIndex = 0;
            int dollyIndex = numbers.Length - 1;

            BigInteger mollyTotalFlowers = 0;
            BigInteger dollyTotalFlowers = 0;

            string winner = string.Empty;

            while (true)
            {
               

                if (numbers[mollyIndex] == 0 || numbers[dollyIndex] == 0)
                {
                    if (numbers[mollyIndex] == 0 && numbers[dollyIndex] == 0)
                    {
                        winner = "Draw";
                    }
                    else if (numbers[mollyIndex] == 0)
                    {
                        winner = "Dolly";
                    }
                    else if (numbers[dollyIndex] == 0)
                    {
                        winner = "Molly";
                    }
                  

                    mollyTotalFlowers += numbers[mollyIndex];
                    dollyTotalFlowers += numbers[dollyIndex];
                    break;
                }

                BigInteger currentMollyFlowers = numbers[mollyIndex];
                BigInteger currentDollyFlowers = numbers[dollyIndex];

                if (mollyIndex == dollyIndex)
                {
                    numbers[mollyIndex] = currentMollyFlowers % 2;
                    mollyTotalFlowers += currentMollyFlowers / 2;
                    dollyTotalFlowers += currentDollyFlowers / 2;
                }
                else
                {
                    numbers[mollyIndex] = 0;
                    numbers[dollyIndex] = 0;

                    mollyTotalFlowers += currentMollyFlowers;
                    dollyTotalFlowers += currentDollyFlowers;
                }

                mollyIndex = (int)((mollyIndex +  currentMollyFlowers) % numbers.Length);

                dollyIndex = (int)((dollyIndex - currentDollyFlowers) % numbers.Length);
                if (dollyIndex < 0)
                {
                    dollyIndex += numbers.Length; 
                }
            }

            Console.WriteLine(winner);
            Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);
        }
    }
}

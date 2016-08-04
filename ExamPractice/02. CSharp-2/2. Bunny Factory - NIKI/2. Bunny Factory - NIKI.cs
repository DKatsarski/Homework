using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bunny_Factory___NIKI
{
    class Program
    {
        static void Main(string[] args)
        {
            var cages = Input();

            for (int stepNumber = 1; ; stepNumber++)
            {
                if (cages.Count < stepNumber)
                {
                    break;
                }


                var cagesCount = (int)SumListValuesInRange(cages, 0, stepNumber - 1);

                if (cages.Count < stepNumber + cagesCount)
                {
                    break;
                }

                var sum = SumListValuesInRange(cages, stepNumber, cagesCount + stepNumber - 1);
                var product = ProductListValuesInRange(cages, stepNumber, cagesCount + stepNumber - 1);
                string result = sum.ToString() + product.ToString();

                for (int i = cagesCount + stepNumber; i < cages.Count; i++)
                {
                    result += cages[i];
                }

                cages = result.Where(x => x != '0' && x != '1').Select(x => x - '0').ToList();




            }



            Console.WriteLine(string.Join(" ", cages));

        }

        static BigInteger ProductListValuesInRange(List<int> list, int startIndex, int endIndex)
        {
            BigInteger product = 1;
            for (int i = startIndex; i <= endIndex; i++)
            {
                product *= list[i];
            }

            return product;
        }

        static BigInteger SumListValuesInRange(List<int> list, int startIndex, int endIndex)
        {
            BigInteger sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += list[i];
            }
            return sum;
        }


        static List<int> Input()
        {
            var cages = new List<int>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var cage = int.Parse(line);
                cages.Add(cage);
            }

            return cages;


        }
    }
}

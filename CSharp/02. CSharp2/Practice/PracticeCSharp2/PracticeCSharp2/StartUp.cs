using Bazik;
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
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };  //Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            plusMinus(arr);

        }

        static void plusMinus(int[] arr)
        {
            double counterPositiveNumbers = 0;
            double counterNegativeNumbers = 0;
            double counterOfZeroes = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    counterPositiveNumbers += 1;
                }
                else if (arr[i] < 0)
                {
                    counterNegativeNumbers += 1;
                }
                else if (arr[i] == 0)
                {
                    counterOfZeroes += 1;
                }
            }

            double postiiveFractoin = counterPositiveNumbers / arr.Length;
            double negativeFraction = counterNegativeNumbers / arr.Length;
            double zeroFraction = counterOfZeroes / arr.Length;

            Console.WriteLine("{0:F6}", postiiveFractoin);
            Console.WriteLine("{0:F6}", negativeFraction);
            Console.WriteLine("{0:F6}", zeroFraction);



        }

    }
}

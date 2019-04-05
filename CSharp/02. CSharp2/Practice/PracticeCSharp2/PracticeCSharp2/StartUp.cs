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
            var arr = new int[] { 3 ,2 ,1 ,3 }; // Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(  birthdayCakeCandles(arr));
        }

        static int birthdayCakeCandles(int[] ar)
        {
            int maxNumber = ar.Max();
            int counter = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == maxNumber)
                {
                    counter++;
                }
            }

            return counter;

        }
    }
}

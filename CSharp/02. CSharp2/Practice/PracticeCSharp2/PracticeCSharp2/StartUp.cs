using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class StartUp
    {
        static void Main()
        {
            var array = rotLeft(new int[] { 2, 3, 4, 5 }, 3);
            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
        }

        static int[] rotLeft(int[] arrayToBeRotaed, int numberOfRotations)
        {
            int[] rotaedArray = new int[arrayToBeRotaed.Length];

            for (int i = 0; i < arrayToBeRotaed.Length; i++)
            {
                rotaedArray[((rotaedArray.Length + i) - (numberOfRotations % rotaedArray.Length)) % rotaedArray.Length] = arrayToBeRotaed[i];
            }

            return rotaedArray;
        }







    }
}
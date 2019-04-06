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
           


            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            

            int[] rotatedArray = new int[a.Length];
            int numberOfTimesToBeRotated = d;

            for (int i = 0; i < a.Length; i++)
            {
             
                rotatedArray[((rotatedArray.Length + i) - (numberOfTimesToBeRotated % rotatedArray.Length)) % rotatedArray.Length] = a[i];
            }

            foreach (var number in rotatedArray)
            {
                Console.Write(number + " ");

            }
        }


    }
}

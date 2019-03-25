using Bazik;
using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public delegate void Asdf();
    public class PracticeCSharp2
    {
        static void Main()
        {

            int c = 3;
            int[] exampleArray = new int[] { 4, 5, 3, 3, 2, 6, 7 };


            Console.WriteLine(TimesANumberIsFoundInAnArray(exampleArray, c));


        }

        public static int TimesANumberIsFoundInAnArray(int[] givenArray, int numberToBeSearched)
        {
            int timesTheNumbersIsSpoted = 0;

            for (int i = 0; i < givenArray.Length; i++)
            {
                if (givenArray[i] == numberToBeSearched)
                {
                    timesTheNumbersIsSpoted += 1;
                }
            }

            return timesTheNumbersIsSpoted;
        }

    }
}
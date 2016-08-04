using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessNumber = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());


            for (int currentNumber = 1000; currentNumber <= 9999; currentNumber++)
            {
                int currentBulls = 0;
                int currentCows = 0;

                int currentD = currentNumber % 10;
                currentNumber /= 10;
                int currentC = currentNumber % 10;
                currentNumber /= 10;
                int currentB = currentNumber % 10;
                currentNumber /= 10;
                int currentA = currentNumber % 10;
                currentNumber /= 10;

                int tempGuessNumber = guessNumber;
                int guessNumberD = tempGuessNumber % 10;
                tempGuessNumber /= 10;
                int guessNumberC = tempGuessNumber % 10;
                tempGuessNumber /= 10;
                int guessNumberB = tempGuessNumber % 10;
                tempGuessNumber /= 10;
                int guessNumberA = tempGuessNumber % 10;
                tempGuessNumber /= 10;
                #region FindBulls

                if (currentA == guessNumberA)
                {
                    currentBulls++;
                    currentA = -1;
                    guessNumberA = -2;

                }
                if (currentB == guessNumberA)
                {
                    currentBulls++;
                    currentA = -1;
                    guessNumberA = -2;

                }
                if (currentC == guessNumberA)
                {
                    currentBulls++;
                    currentA = -1;
                    guessNumberA = -2;

                }
                if (currentD == guessNumberA)
                {
                    currentBulls++;
                    currentA = -1;
                    guessNumberA = -2;

                }
                #endregion



                if (currentA == guessNumberB)
                {
                    currentCows++;
                    currentA = -1;
                    currentB = -2;

                }
                if (currentA == guessNumberC)
                {
                    currentCows++;
                    currentA = -1;
                    currentC = -2;

                }
                if (currentA == guessNumberD)
                {
                    currentCows++;
                    currentA = -1;
                    currentD = -2;

                }
                if (currentB == guessNumberA)
                {
                    currentCows++;
                    currentB = -1;
                    currentA = -2;

                }
                if (currentB == guessNumberC)
                {
                    currentCows++;
                    currentB = -1;
                    currentC = -2;

                }
                if (currentB  == guessNumberD)
                {
                    currentCows++;
                    currentB = -1;
                    currentD = -2;

                }
                if (currentC == guessNumberA)
                {
                    currentCows++;
                    currentC = -1;
                    currentA = -2;

                }
                if (currentC == guessNumberB)
                {
                    currentCows++;
                    currentC = -1;
                    currentB = -2;

                }
                if (currentC == guessNumberD)
                {
                    currentCows++;
                    currentC = -1;
                    currentD = -2;

                }
                if (currentD == guessNumberA)
                {
                    currentCows++;
                    currentD = -1;
                    currentA = -2;

                }
                if (currentD == guessNumberA)
                {
                    currentCows++;
                    currentD = -1;
                    currentB = -2;

                }
                if (currentD == guessNumberA)
                {
                    currentCows++;
                    currentC = -1;
                    currentA = -2;

                }
                //TODO: findthem 

                if (currentBulls == bulls && currentCows == cows)
                {
                    Console.Write("{0} ", currentNumber);
                }
            }
            Console.WriteLine();
        }

    }
}

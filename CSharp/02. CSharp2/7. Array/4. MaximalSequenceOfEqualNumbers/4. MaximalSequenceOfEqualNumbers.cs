using System;

namespace _4.MaximalSequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            double counter = 1;
            double currentScore = 0;
            double winnerScore = 0;

            // fill the Array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }


            // iterate through the elements of the array
            for (int j = 0; j < arr.Length - 1; j++)
            {
             
                if (arr[j] == arr[j + 1])
                {
                    
                    counter++;
                    currentScore += counter;
                    counter = 0;
                }
                if (currentScore > winnerScore && (arr[j] != arr[j + 1] || j == arr.Length - 2))
                {
                    winnerScore = currentScore;
                    currentScore = 0;
                }
                if (arr[j] != arr[j + 1])
                {
                    currentScore = 0;
                    counter = 1;
                }

            }
            Console.WriteLine(winnerScore);
        }
    }
}

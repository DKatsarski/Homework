using System;

namespace _2.Speeds
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the sum of initials speeds of the longest group (the goup with most cars)
            int numberOfCars = int.Parse(Console.ReadLine()); 

            int[] cars = new int[numberOfCars];
            int firstGroupOfCars = 0;
            int duuuuCount = 0;
            int result = 0;
            int counterOfGroups = 0;
            int counterEqual = 0;
            int counterBigger = 0;
            int highestNumber = 0;

            for (int i = 0; i < cars.Length; i++) 
            {
                int numberInArray = int.Parse(Console.ReadLine());

                cars[i] = numberInArray;
            }
            
            for (int j = 0; j < cars.Length - 1; j++)
            {
                if (cars[j] < cars[j + 1])
                {
                    if (cars[j] == cars[0] || cars[j] < cars[j - 1])
                    {
                        result = cars[j] + cars[j + 1];
                        counterOfGroups++;
                    }
                    else
                    {
                        result += cars[j + 1];
                        counterOfGroups++;
                    }
                }
                else if (cars[j] == cars[j + 1])
                {
                    result = cars[j];
                    counterEqual++;
                }
                else if (cars[j] > cars[j + 1])
                {
                    highestNumber = cars[j];

                    if (highestNumber > cars[j])
                    {
                        result = highestNumber;
                    }

                    counterBigger++;
                }

                if (result > firstGroupOfCars && counterOfGroups > duuuuCount && counterOfGroups > counterBigger)
                {
                    firstGroupOfCars = result;
                    duuuuCount = counterOfGroups;

                    counterOfGroups = 0;
                }
            }

            Console.WriteLine(result);
        }
    }
}

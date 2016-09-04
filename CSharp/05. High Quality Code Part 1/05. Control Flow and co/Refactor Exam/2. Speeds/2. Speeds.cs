using System;

namespace _2.Speeds
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the sum of initials speeds of the longest group (the goup with most cars)
            int c = int.Parse(Console.ReadLine());  // number of cars

            int[] helper = new int[c];
            int firstGroup = 0;
            int duuuuCount = 0;
        
            int counter = 0;
            int counterGroups = 0;
            int counterEqual = 0;
            int counterBigger = 0;
            int bigger = 0;

             

            for (int i = 0; i < c; i++) // pylnq si masiwa 
            {

                int a = int.Parse(Console.ReadLine());

                helper[i] = a;

            }




            for (int j = 0; j < helper.Length - 1; j++) //obhojdam go
            {

                if (helper[j] < helper[j + 1])
                {
                    if (helper[j] == helper[0] || helper[j] < helper[j - 1])
                    {
                        counter = helper[j] + helper[j + 1];
                        counterGroups++;
                    }
                    else
                    {
                        counter += helper[j + 1];
                        counterGroups++;
                    }

                }
                else if (helper[j] == helper[j + 1])
                {
                    counter = helper[j];
                    counterEqual++;
                }
                else if (helper[j] > helper[j + 1])
                {
                    
                        bigger = helper[j];

                    if (bigger > helper[j])
                    {
                        counter = bigger;
                    }

                    counterBigger++;
                  
                    
                    
                }
                if (counter > firstGroup && counterGroups > duuuuCount && counterGroups > counterBigger)
                {

                    firstGroup = counter;
                    duuuuCount = counterGroups;

                    counterGroups = 0;
                }


            }
            Console.WriteLine(counter);






        }
    }
}

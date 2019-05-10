namespace PracticeCSharp2
{
    using System.Collections.Generic;
    using System;

    public class StartUp
    {

         static void Main()
        {
            var array = new int[] { 2, 1, 5, 3, 4 };
            var newArray = new int[] { 2, 5, 1, 3, 4 };

            minimumBribes(array);
            minimumBribes(newArray);
        }


        static void minimumBribes(int[] arr)
        {
            int n = arr.Length;
            int counter = 0;


            if (counter <= 2)
            {


                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            // swap temp and arr[i] 
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            counter += 1;
                        }
                    }
                }
                if (counter > 2)
                {
                    Console.WriteLine(counter);
                    Console.WriteLine("Too chaotic");

                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }

}

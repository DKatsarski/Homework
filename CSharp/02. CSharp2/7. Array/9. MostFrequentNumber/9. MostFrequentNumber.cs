using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 0;
            int maxCounter = 0;
            int theNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length; j > i; j--)
                {

                    if (arr[i] == arr[j - 1])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            theNumber = arr[i];
                          
                        }
                    }

                }
                counter = 0;


            }
            Console.WriteLine("{0} ({1} times)", theNumber, maxCounter);

        }
    }


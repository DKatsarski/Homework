using System;

namespace _7.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] allocateArray = new int[input];
            int counter = 0;

            Console.WriteLine(0);

            for (int i = 0; i < allocateArray.Length - 1; i++)
            {

             
                counter += 5;
                allocateArray[i] = counter;
                Console.WriteLine(allocateArray[i]);
            }

        }
    }
}

using System;


namespace _2.Compare_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            bool equal = false;

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < secondArray.Length; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < firstArray.Length; i++)
            {

                if (firstArray[i] != secondArray[i])
                {
                    equal = false;
                    break;
                }
                else if (firstArray[i] == secondArray[i])
                {
                    equal = true;
                }
              }

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        


        }
    }
}

namespace ControlFlowAndStuff
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Task 3. Refactor the following loop
            int expectedValue = 54;

            int[] array = new int[100];

            FillArray(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

                if (array[i] == expectedValue)
                {
                    Console.WriteLine("Value Found");

                    break;
                }
            }
        }

        private static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }
    }
}

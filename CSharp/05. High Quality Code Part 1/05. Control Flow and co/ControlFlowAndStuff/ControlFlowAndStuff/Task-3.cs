using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
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

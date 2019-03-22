using Bazik;
using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public delegate void Asdf();
    public class PracticeCSharp2
    {
        static void Main()
        {
            //Write a program, that reads from the console an array of N integers and an integer K, 
            //sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int value = 0;
            int valueForSearch = 1;
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);

            value = Array.BinarySearch(array, k);

            while (value < 0)
            {
                value = Array.BinarySearch(array, k - valueForSearch);
                valueForSearch++;
            }
            Console.WriteLine(array[value]);


        }

        public  static void Something()
        {
            Console.WriteLine("sdf");
        }
    }
}
using System;
using System.Linq;


namespace _3.MMSA_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] arrayNumbers = new double[n];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                double variable = double.Parse(Console.ReadLine());
                arrayNumbers[i] = variable;
            }

            double minimum = arrayNumbers.Min();
            Console.WriteLine("min={0:F2}", minimum);
            double maximum = arrayNumbers.Max();
            Console.WriteLine("max={0:F2}", maximum);
            double sumarry = arrayNumbers.Sum();
            Console.WriteLine("sum={0:F2}", sumarry);
            double avarage = arrayNumbers.Average();
            Console.WriteLine("avg={0:F2}", avarage);
        }
    }
}

using System;

namespace ExamPractice
{
    class Program
    {
        static void Main(string[] args)
        {   
            // how much money they save

            int n = int.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double part = (n * s) / 5;
            double price = (part * p) / 100;
            Console.WriteLine("{0:F2}", price);
        }
    }
}

using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double variable = Math.Pow(x, 2) + Math.Pow(y, 2);
            double radius = Math.Sqrt(variable);
           
            if (radius <= 2)
            {
                Console.WriteLine("yes {0:F2}", radius);
            }
            else
            {
                Console.WriteLine("no {0:F2}", radius);
            }
           
        }
    }
}

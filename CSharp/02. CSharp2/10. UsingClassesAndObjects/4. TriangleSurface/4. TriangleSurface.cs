using System;

namespace _4.TriangleSurface
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
           
            double result = (altitude * side) / 2;
            Console.WriteLine("{0:F2}", result);


        }
    }
}

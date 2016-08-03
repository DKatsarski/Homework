using System;


namespace _3.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * (Math.PI * radius);
            double area = Math.PI * (Math.Pow(radius, 2));

            Console.Write("{0:F2} {1:F2}", perimeter, area);
            Console.ReadLine();
        }
    }
}

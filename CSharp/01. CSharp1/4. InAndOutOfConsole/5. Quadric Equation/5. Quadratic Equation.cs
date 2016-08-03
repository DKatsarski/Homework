using System;

namespace _5.Quadric_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double xPlus = (-(b) - Math.Sqrt((Math.Pow(b, 2)) - (4 * (a * c)))) / (2 * a);
            double xMinus = (-(b) + Math.Sqrt((Math.Pow(b, 2)) - (4 * (a * c)))) / (2 * a);

            double smallerNumber = Math.Min(xPlus, xMinus);
            double biggerNumber = Math.Max(xPlus, xMinus);

        
            if (xPlus == xMinus)
            {
                Console.WriteLine("{0:F2}", xPlus);
            }
            else if (Double.IsNaN(xPlus) || Double.IsNaN(xMinus))
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                Console.WriteLine("{0:F2}", smallerNumber);
                Console.WriteLine("{0:F2}", biggerNumber);
            }
          
        }
    }
}

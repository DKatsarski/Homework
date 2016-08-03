using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleFormula
{
    class CircleFormula
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a radius of a Circle: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = (2 * Math.PI * radius);
            double area = radius * radius * Math.PI;
            Console.WriteLine("The perimeter of the circle is {0:F3}", perimeter);
            Console.WriteLine("The area is {0:F3}", area);
        }
    }
}
